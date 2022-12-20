using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAB.AdvertisementApp.DataAccess.Contexts;
using YAB.AdvertisementApp.DataAccess.Interfaces;
using YAB.AdvertisementApp.DataAccess.Repositories;
using YAB.AdvertisementApp.Entities;

namespace YAB.AdvertisementApp.DataAccess.UnitOfWork
{
    public class Uow:IUow
    {
        private readonly AdvertisementContext _context;

        public Uow(AdvertisementContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T: BaseEntity
        {
            return new Repository<T>(_context);
        }


        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
