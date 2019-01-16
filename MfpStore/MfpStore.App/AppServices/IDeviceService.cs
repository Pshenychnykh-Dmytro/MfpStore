using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.App.AppServices
{
    public interface IDeviceService
    {
        void Add(DeviceDto deviceDto);
        void Update(DeviceDto deviceDto);
        void DeleteById(Guid id);
        DeviceDto GetById(Guid id);
        IEnumerable<DeviceDto> GetAll();
    }
}
