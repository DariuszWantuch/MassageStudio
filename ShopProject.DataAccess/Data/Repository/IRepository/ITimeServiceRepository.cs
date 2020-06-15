using Microsoft.AspNetCore.Mvc.Rendering;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository.IRepository
{
    public interface ITimeServiceRepository : IRepository<TimeService>
    {
        IEnumerable<SelectListItem> GetTimeServiceListForDropDown();

        void Update(TimeService timeService);
        public bool IsTimeServiceExist(string time);
    }
}
