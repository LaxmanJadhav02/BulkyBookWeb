﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
   public  interface IRepository<T> where T : class
    {
        //T- category
        T GetfirstOrDefault(Expression<Func<T,bool>> filter);

        IEnumerable<T> Getall();

        void Add(T entity);

        void Remove(T entity);

        void Remove(IEnumerable<T>  entity);
    }
}
