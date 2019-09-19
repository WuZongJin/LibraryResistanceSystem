using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryEntities;
using LibraryEntities.Models;
using static LibraryEntities.Models.LibrarySeat;

namespace LibraryServices
{
    public class LibrarySeatService : ILibrarySeatService
    {
        public static int CheckInTime = 15;
        public static int OrderEndTime = 2;
        private IRepository<LibrarySeat> _librarySeatRepository;
        private IRepository<SysUser> _userRepository;
        private IRepository<OrderDetail> _orderRepository;
        private object locker = new object();

        public LibrarySeatService(IRepository<LibrarySeat> librarySeatRepository, IRepository<SysUser> userRepository,IRepository<OrderDetail> orderRepositiory)
        {
            _librarySeatRepository = librarySeatRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepositiory;

            
        }



        public IList<LibrarySeat> GetALLLibrarySeat()
        {
            return _librarySeatRepository.Table.ToList();
        }

        public IList<LibrarySeat> GetLibrarySetsAvailable(int floor)
        {
            return _librarySeatRepository.Table.Where(s => s.Floor == floor && s.SeatState == SeatStates.Available).ToList();
        }

        public IList<LibrarySeat> GetLibrarySetsBooked(int floor)
        {
            return _librarySeatRepository.Table.Where(s => s.Floor == floor && s.SeatState == SeatStates.Booked).ToList();
        }

        public IList<LibrarySeat> GetLibrarySetsInAvailable(int floor)
        {
            return _librarySeatRepository.Table.Where(s => s.Floor == floor && s.SeatState == SeatStates.InAvailable).ToList();
        }

        public (int avilable, int booked, int inavilable) GetLibrarySeatCount(int floor)
        {
            int avilable = _librarySeatRepository.Table.Where(s => s.Floor == floor && s.SeatState == SeatStates.Available).Count();
            int booked = _librarySeatRepository.Table.Where(s => s.Floor == floor && s.SeatState == SeatStates.Booked).Count();
            int inavilable = _librarySeatRepository.Table.Where(s => s.Floor == floor && s.SeatState == SeatStates.InAvailable).Count();

            return (avilable, booked, inavilable);
        }

        public (bool state, string message, LibrarySeat seat, OrderDetail order) Schedule(Guid seatId,Guid userId)
        {
            var seat = _librarySeatRepository.GetById(seatId);
            var user = _userRepository.GetById(userId);


            if(seat.SeatState == SeatStates.Booked)
            {
                return (false, "座位已被预定", null, null);
            }
            else if(seat.SeatState == SeatStates.InAvailable)
            {
                return (false, "座位上已经有人了", null, null);
            }

            lock (locker)
            {
                var order = new OrderDetail();
                order.Id = Guid.NewGuid();
                order.LibrarySeatId = seat.Id;
                order.HasCheckIn = false;
                order.CreateTime = DateTime.Now;
                order.VerificationCode = "558879";
                order.EndTime = DateTime.Now.AddHours(2);
                order.HasEnd = false;

                seat.OrderDetails.Add(order);
                user.OrderDetails.Add(order);

                if(seat.SeatState == SeatStates.Available)
                {
                    seat.SeatState = SeatStates.Booked;
                }
                else
                {
                    return (false, "位置信息以改变", null, null);
                }
                

                try
                {
                    _librarySeatRepository.DbContext.SaveChanges();
                    
                }
                catch (Exception)
                {
                    return (false, "发生错误请重试！", null, null);
                }

                return (true, "预定成功", seat, order);
            }
        }

        public bool ChageLibrarySeatState(Guid seatId,SeatStates state)
        {
            lock (locker)
            {
                var seat = _librarySeatRepository.GetById(seatId);
                if (seat == null)
                    return false;

                seat.SeatState = state;
                try
                {
                    _librarySeatRepository.Update(seat);
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            }
        }

        public void UpdateSeatState()
        {
            var ordersHasNotEnd = _orderRepository.Table
                .Where(o => o.HasEnd == false);

            var orderCheckInTimeOut = ordersHasNotEnd
                .Where(o => o.HasCheckIn == false && DateTime.Now >= o.CreateTime.AddMinutes(CheckInTime));

            var orderEndTimeOut = ordersHasNotEnd
                .Where(o => DateTime.Now >= o.CreateTime.AddHours(OrderEndTime));

            var shouldChangeStateorder = orderEndTimeOut.Union(orderCheckInTimeOut);

            foreach(var order in shouldChangeStateorder)
            {
                var seat = _librarySeatRepository.GetById(order.LibrarySeatId);
                seat.SeatState = SeatStates.Available;
            }

            lock(locker)
            {
                _librarySeatRepository.DbContext.SaveChanges();
            }
        }
    }
}
