using Microsoft.AspNetCore.Mvc.Rendering;
using ShopProject.DataAccess.Data.Repository.IRepository;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
