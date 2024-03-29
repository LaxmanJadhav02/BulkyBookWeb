﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDBContext _db;

        public CategoryRepository(ApplicationDBContext db) :base(db)
        {
            _db = db;
        }
       

        void ICategoryRepository.Update(Category obj)
        {
            _db.categories.Update(obj);
        }
    }
}
