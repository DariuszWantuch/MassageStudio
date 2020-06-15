using Microsoft.EntityFrameworkCore;
using NSubstitute;
using ShopProject.DataAccess.Data.Repository.IRepository;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ShopProjectTests
{
    public class AddCategoryTest
    {
        public DbSet<Category> _db;
        private readonly IUnitOfWork _unitOfWork;
        [Fact]
        public void AddCategory_WhenExist_ShouldFail()
        {
            Category category = new Category(1,"Beczka");


            _db.Add(category);
            var unitOfWorkSubstitute = Substitute.For<IUnitOfWork>();



        }
    }
}
