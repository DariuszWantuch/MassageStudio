using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ITimeServiceRepository TimeService { get; }
        IServiceRepository Service { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailsRepository OrderDetails { get; }    
        IUserRepository User { get; }
        void Save();
    }
}
