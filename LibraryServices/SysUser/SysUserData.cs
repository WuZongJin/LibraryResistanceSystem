using CommonUlities;
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
    public static class SysUserData
    {
        public static string salt = "asd558879";
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyDbContext(serviceProvider.GetRequiredService<DbContextOptions<MyDbContext>>()))
            {
                if (context.SysUsers.Any())
                {
                    return;
                }

                context.SysUsers.AddRange(
                    new SysUser
                    {
                        Id = Guid.NewGuid(),
                        Account = "41606217",
                        Name = "吴宗锦",
                        Salt = salt,
                        Password = Password.GetMd5Hash(salt, "15160296867"),
                        IsAdmin = false,
                        CreationTime = DateTime.Now,
                        LoginFailedNum = 0,
                        AllowLoginTime = null,
                        LoginLock = false,
                        LastLoginTime = null,
                        ViolationNum = 0,
                        ScheduledLock = false,
                        AllowScheduleTime = null,
                    },

                    new SysUser
                    {
                        Id = Guid.NewGuid(),
                        Account = "41606215",
                        Name = "艾杰尔",
                        Salt = salt,
                        Password = Password.GetMd5Hash(salt, "558879"),
                        IsAdmin = false,
                        CreationTime = DateTime.Now,
                        LoginFailedNum = 0,
                        AllowLoginTime = null,
                        LoginLock = false,
                        LastLoginTime = null,
                        ViolationNum = 0,
                        ScheduledLock = false,
                        AllowScheduleTime = null,
                    },

                    new SysUser
                    {
                        Id = Guid.NewGuid(),
                        Account = "41606214",
                        Name = "马尔斯",
                        Salt = salt,
                        Password = Password.GetMd5Hash(salt, "12345678"),
                        IsAdmin = false,
                        CreationTime = DateTime.Now,
                        LoginFailedNum = 0,
                        AllowLoginTime = null,
                        LoginLock = false,
                        LastLoginTime = null,
                        ViolationNum = 0,
                        ScheduledLock = false,
                        AllowScheduleTime = null,
                    },

                    new SysUser
                    {
                        Id = Guid.NewGuid(),
                        Account = "41606213",
                        Name = "林杰",
                        Salt = salt,
                        Password = Password.GetMd5Hash(salt, "12345678"),
                        IsAdmin = false,
                        CreationTime = DateTime.Now,
                        LoginFailedNum = 0,
                        AllowLoginTime = null,
                        LoginLock = false,
                        LastLoginTime = null,
                        ViolationNum = 0,
                        ScheduledLock = false,
                        AllowScheduleTime = null,
                    },

                    new SysUser
                    {
                        Id = Guid.NewGuid(),
                        Account = "41606212",
                        Name = "张斌",
                        Salt = salt,
                        Password = Password.GetMd5Hash(salt, "12345678"),
                        IsAdmin = false,
                        CreationTime = DateTime.Now,
                        LoginFailedNum = 0,
                        AllowLoginTime = null,
                        LoginLock = false,
                        LastLoginTime = null,
                        ViolationNum = 0,
                        ScheduledLock = false,
                        AllowScheduleTime = null,
                    }

                    );

                context.SaveChanges();
                
            }
        }
    }
}
