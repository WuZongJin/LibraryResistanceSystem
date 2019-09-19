using LibraryEntities;
using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryServices
{
    public interface  ILibrarySeatService
    {
        IList<LibrarySeat> GetALLLibrarySeat();
        IList<LibrarySeat> GetLibrarySetsAvailable(int floor);
        IList<LibrarySeat> GetLibrarySetsInAvailable(int floor);
        IList<LibrarySeat> GetLibrarySetsBooked(int floor);
        (int avilable, int booked, int inavilable) GetLibrarySeatCount(int floor);
        (bool state, string message, LibrarySeat seat, OrderDetail order) Schedule(Guid seatId,Guid userId);
        void UpdateSeatState();

    }
}
