using LibraryEntities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryEntities
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysUserToken> SysUserTokens { get; set; }
        public DbSet<LibrarySeat> LibrarySeats { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
