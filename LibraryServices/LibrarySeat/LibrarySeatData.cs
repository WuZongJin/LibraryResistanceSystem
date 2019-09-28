using LibraryEntities;
using LibraryEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public static class LibrarySeatData
    {
        public static object locker = new object();
        public static int SqlUpdateLibrarySeatTime = 30;        //
        public static int CheckInTime = 15;     //打卡限定时间 单位分钟
        public static int OrderEndTime = 2;     //预定默认时间 单位小时

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyDbContext(serviceProvider.GetRequiredService<DbContextOptions<MyDbContext>>()))
            {
                if (context.LibrarySeats.Any())
                {
                    return;
                }
                context.LibrarySeats.AddRange(CreateLibrarySeat(1,10));
                context.LibrarySeats.AddRange(CreateLibrarySeat(2, 10));

                context.SaveChanges();
                   
            }
        }

        public static LibrarySeat[] CreateLibrarySeat(int floor,int count)
        {
            LibrarySeat[] librarySeats = new LibrarySeat[count];
            for(int i = 0; i < count; i++)
            {
                LibrarySeat seat = new LibrarySeat();
                seat.Id = Guid.NewGuid();
                seat.Floor = floor;
                seat.SeatNumber = floor * 100 + i + 1;
                seat.SeatState = LibrarySeat.SeatStates.Available;
                librarySeats[i] = seat;
            }

            return librarySeats;
        }
    }
}
