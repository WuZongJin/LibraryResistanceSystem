using LibraryEntities;
using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryEntities.Models.LibrarySeat;

namespace LibraryServices
{
    public class UpdateLibrarySeatService:IUpdateLibrarySeatStateService
    {
        private IRepository<LibrarySeat> _librarySeatRepository;
        private IRepository<OrderDetail> _orderRepository;
        Stopwatch stopwatch = new Stopwatch();
        int pretime = 0;
        int curtime = 0;
        int timer = 0;

        public UpdateLibrarySeatService(IRepository<LibrarySeat> libraryRepository,IRepository<OrderDetail> orderRepository)
        {
            _librarySeatRepository = libraryRepository;
            _orderRepository = orderRepository;
            
        }

        public void Run()
        {
            Task.Run(
                () => Update()
                );
        }

        public void UpdateSeatState()
        {
            var ordersHasNotEnd = _orderRepository.Table
                .Where(o => o.HasEnd == false);

            var orderCheckInTimeOut = ordersHasNotEnd
                .Where(o => o.HasCheckIn == false && DateTime.Now >= o.CreateTime.AddMinutes(LibrarySeatData.CheckInTime));

            var orderEndTimeOut = ordersHasNotEnd
                .Where(o => DateTime.Now >= o.CreateTime.AddHours(LibrarySeatData.OrderEndTime));

            var shouldChangeStateorder = orderEndTimeOut.Union(orderCheckInTimeOut);

            foreach (var order in shouldChangeStateorder)
            {
                order.HasEnd = true;
                var seat = _librarySeatRepository.GetById(order.LibrarySeatId);
                seat.SeatState = SeatStates.Available;
            }

            lock (LibrarySeatData.locker)
            {
                _librarySeatRepository.DbContext.SaveChanges();
            }
        }


        public void Update()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                curtime = stopwatch.Elapsed.Seconds;

                timer += (curtime - pretime);

                pretime = curtime;
                if(timer > LibrarySeatData.SqlUpdateLibrarySeatTime)
                {
                    timer = 0;
                    UpdateSeatState();
                }
            }
        }

    }
}
