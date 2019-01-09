using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.Models;

namespace MfpStore.App.Data
{
    public interface IUnitOfWork
    {
        IRepository<Device> Devices { get; }

        void SaveChanges();
    }
}
