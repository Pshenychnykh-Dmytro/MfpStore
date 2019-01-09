using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.Models;

namespace MfpStore.App.Data
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly EntityContext _context;

        public UnitOfWork(EntityContext context)
        {
            _context = context;
            Devices = new BaseRepository<Device>(_context);
        }

        public IRepository<Device> Devices { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
