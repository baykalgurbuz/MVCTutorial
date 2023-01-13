﻿using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
        
        public List<Category> GetAll()
        {
            return repository.List();
        }
        public void CategoryAdd(Category category)
        {
            if (category.CategoryName=="" || category.CategoryName.Length <= 3 || 
                category.CategoryDescription == "" || category.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repository.Insert(category);
            }
        }
    }
}
