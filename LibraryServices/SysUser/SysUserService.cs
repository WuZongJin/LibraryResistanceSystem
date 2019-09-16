using CommonUlities;
using LibraryEntities;
using LibraryEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class SysUserService:ISysUserService
    {
        private IMemoryCache _memoryCache;
        private IRepository<SysUser> _userRepository;
        private IRepository<SysUserToken> _tokenRepository;
        public const string MODEL_KEY = "libaray.userkey";

        public SysUserService(IRepository<SysUser> userRepository, IRepository<SysUserToken> tokenRepository, IMemoryCache memoryCache)
        {
            _userRepository = userRepository;
            _tokenRepository = tokenRepository;
            _memoryCache = memoryCache;
        }

        public SysUser GetByAccount(string account)
        {
            return _userRepository.Table.FirstOrDefault(u => u.Account == account);
        }

        public SysUser GetLogined(string token)
        {
            SysUser user = null;
            SysUserToken userToken = null;
            _memoryCache.TryGetValue<SysUserToken>(token, out userToken);

            if (userToken != null)
                _memoryCache.TryGetValue($"{MODEL_KEY}{userToken.SysUserId}", out user);

            if (user != null)
                return user;

            Guid tokenId = Guid.Empty;
            if(Guid.TryParse(token,out tokenId))
            {
                var tokenItem = _tokenRepository.Table.Include(t => t.SysUser).FirstOrDefault(u => u.Id == tokenId);

                if(tokenItem != null)
                {
                    _memoryCache.Set($"{MODEL_KEY}{userToken.SysUserId}", tokenItem.SysUser, DateTime.Now.AddHours(4));
                    return tokenItem.SysUser;
                }
            }
            return null;
        }

        public (bool status, string message, string token, SysUser user) AvailableDataUser(string account, string password, string R)
        {
            var user = GetByAccount(account);
            if (user == null)
                return (false, "用户不存在", null, null);

            if (user.LoginLock)
            {
                if(user.AllowLoginTime>DateTime.Now)
                {
                    return (false, $"账号已被锁定，{(int)(user.AllowLoginTime - DateTime.Now).Value.TotalSeconds + 1}", null, null);
                }
            }

            bool isPasswordCorect = Password.VerifyMd5Hash(user.Salt, password, user.Password);
            if (isPasswordCorect)
            {
                user.LoginLock = false;
                user.LoginFailedNum = 0;
                user.LastLoginTime = DateTime.Now;
                user.AllowLoginTime = null;

                var userToken = new SysUserToken()
                {
                    Id = Guid.NewGuid(),
                    ExpireTime = DateTime.Now.AddDays(15),
                };
                user.SysUserTokens.Add(userToken);
                _userRepository.DbContext.SaveChanges();
                return (true, "登录成功", userToken.Id.ToString(), user);
            }
            else
            {
                user.LoginFailedNum++;
                if (user.LoginFailedNum > 3)
                {
                    user.LoginLock = true;
                    user.AllowLoginTime = DateTime.Now.AddMinutes(5);
                }
                _userRepository.DbContext.SaveChanges();
                return (false, "密码出错", null, null);
            }
        }

        public IList<SysUser> GetAllSysUser()
        {
            return _userRepository.Table.ToList();
        }

        public  (bool state,string message,SysUser sysUser) RegisterUser(RegisterModel model)
        {
            SysUser user = new SysUser();
            user.Id = Guid.NewGuid();
            user.Account = model.Account;
            user.Name = model.Name;
            user.Salt = Guid.NewGuid().ToString();
            user.Password = Password.GetMd5Hash(user.Salt, model.Password);
            user.IsAdmin = false;
            user.CreationTime = DateTime.Now;
            user.LoginFailedNum = 0;
            user.AllowLoginTime = null;
            user.LoginLock = false;
            user.LastLoginTime = null;
            user.ViolationNum = 0;
            user.ScheduledLock = false;
            user.AllowScheduleTime = null;
            
            if(_userRepository.Table.Where(u=>u.Account == user.Account).Count() > 0)
            {
                return (false, "账号已存在", null);
            }

            try
            {
                _userRepository.Insert(user);
            }catch(Exception)
            {
                return (false, "发生错误，无法注册", null);
            }

            return (true, "注册成功", user);

        }
    }
}
