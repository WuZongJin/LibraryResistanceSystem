using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryEntities.Models
{
    public class LibrarySet
    {
        public Guid Id { get; set; }                    //数据库主键
        [Required]
        public int SeatNumber { get; set; }             //座位编号
        [Required]
        public int Floor { get; set; }                  //座位所在楼层        
        [Required]
        public SeatStates SeatState { get; set; }       //座位状态

        public enum SeatStates
        {
            Available = 0,
            Booked = 1,
            InAvailable = 2,
        }
    }
}
