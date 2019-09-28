﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryCore;
using LibraryEntities;
using LibraryFramework.AdminAuth;
using LibraryFramework.Infrastructure;
using LibraryServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LibraryReservationSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContextPool<MyDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = AdminAuthInfo.AuthenticationScheme;
                o.DefaultChallengeScheme = AdminAuthInfo.AuthenticationScheme;
                o.DefaultSignInScheme = AdminAuthInfo.AuthenticationScheme;
                o.DefaultSignOutScheme = AdminAuthInfo.AuthenticationScheme;
            }).AddCookie(AdminAuthInfo.AuthenticationScheme, o =>
            {
                o.LoginPath = "/Library/Login/Index";
            });

            services.AddSession(o =>
            {
                
            });

            services.AddSingleton<IMemoryCache, MemoryCache>();
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
            services.AddScoped<IAdminAuthService, AdminAuthService>();
            services.AddScoped<ISysUserService, SysUserService>();
            services.AddScoped<ILibrarySeatService, LibrarySeatService>();
            services.AddScoped<IWorkContext, WorkContext>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            EngineContext.Initialize(new Engine(services.BuildServiceProvider()));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                ); 

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

           
        }
    }
}
