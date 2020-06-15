using Microsoft.AspNetCore.Mvc.Rendering;
using ShopProject.DataAccess.Data.Repository.IRepository;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository
{
    public class TimeServiceRepository : Repository<TimeService>, ITimeServiceRepository
    {
        private readonly ApplicationDbContext _db;

        public TimeServiceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetTimeServiceListForDropDown()
        {
            return _db.TimeService.Select(i => new SelectListItem()
            {
                Text = i.Time,
                Value = i.Id.ToString()
            });
        }

        public bool IsTimeServiceExist(string time)
        {           
            return _db.TimeService.Any(
                x => x.Time == time);
        }

        public void Update(TimeService timeService)
        {
            var objFromDb = _db.TimeService.FirstOrDefault(s => s.Id == timeService.Id);

            objFromDb.Time = timeService.Time;

            _db.SaveChanges();
        }

    }
}
