﻿using Homework4.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Dal.Abstract
{
    public interface IUnitofWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;
        bool BeginTransaction();
        bool RollBackTransaction();
        int SaveChanges();
    }
}
