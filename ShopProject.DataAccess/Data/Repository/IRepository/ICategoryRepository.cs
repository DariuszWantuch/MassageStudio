﻿using Microsoft.AspNetCore.Mvc.Rendering;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);

        public bool IsCategoryExist(string name);
       
    }
}
