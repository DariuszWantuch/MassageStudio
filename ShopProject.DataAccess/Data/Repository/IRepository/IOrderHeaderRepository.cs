using Microsoft.AspNetCore.Mvc.Rendering;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void ChangeOrderStatus(int orderHeaderId, string status);
    }
}
