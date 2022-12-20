﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.DataAccess.Interfaces;
using YAB.AdvertisementApp.Entities;

namespace YAB.AdvertisementApp.DataAccess.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;

        Task SaveChangesAsync();
    }
}
