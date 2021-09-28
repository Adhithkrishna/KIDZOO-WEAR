﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingCart_Models;
using ShoppingCart_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_DataAccess.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
      public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            if ( !_roleManager.RoleExistsAsync(WC.AdminRole).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(WC.AdminRole)).GetAwaiter().GetResult();
                 _roleManager.CreateAsync(new IdentityRole(WC.CustomerRole)).GetAwaiter().GetResult();
            }
            else
            {
                return;
            }

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                FullName = "Admin",
                PhoneNumber = "8592850086"
            }, "@Pass123").GetAwaiter().GetResult();

            ApplicationUser user = _db.ApplicationUser.FirstOrDefault(u => u.Email == "admin@gmail.com");
            _userManager.AddToRoleAsync(user, WC.AdminRole).GetAwaiter().GetResult();

        }
    }
}
