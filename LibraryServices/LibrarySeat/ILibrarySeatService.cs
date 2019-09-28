using LibraryEntities;
using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryServices
{
    public interface  ILibrarySeatService
    {
        IList<LibrarySeat> GetALLLibrarySeat();                     //获取所有的座位信息
        IList<LibrarySeat> GetLibrarySetsAvailable(int floor);      //获取当前楼层信息
        IList<LibrarySeat> GetLibrarySetsInAvailable(int floor);    //获取当前可预订座位信息
        IList<LibrarySeat> GetLibrarySetsBooked(int floor);         //获取以预定座位信息
        (int avilable, int booked, int inavilable) GetLibrarySeatCount(int floor);      //获取当前楼层可用，被预定，被坐的座位数量
        (bool state, string message, LibrarySeat seat, OrderDetail order) Schedule(Guid seatId,Guid userId);        //预定座位
        void UpdateSeatState();         //更新座位信息

    }
}
