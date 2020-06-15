﻿using Microsoft.AspNetCore.Mvc.Rendering;
using ShopProject.DataAccess.Data.Repository.IRepository;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void ChangeOrderStatus(int orderHeaderId, string status)
        {
            var orderFromDb = _db.OrderHeader.FirstOrDefault(o => o.Id == orderHeaderId);
            orderFromDb.Status = status;
            _db.SaveChanges();
        }

    }
}
