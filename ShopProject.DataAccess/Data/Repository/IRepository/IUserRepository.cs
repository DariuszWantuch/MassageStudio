using Microsoft.AspNetCore.Mvc.Rendering;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void LockUser(string userId);

        void UnLockUser(string userId);
    }
}
