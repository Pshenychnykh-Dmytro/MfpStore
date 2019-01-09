using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.App.AppServices
{
    public interface IDeviceService
    {
        void Add(InputDeviceDto deviceDto);
        void Update(InputDeviceDto deviceDto);
        IEnumerable<DeviceDto> GetAll();
    }
}
