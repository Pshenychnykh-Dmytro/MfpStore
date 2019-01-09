using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.AppServices.Dto;
using MfpStore.App.Data;

namespace MfpStore.App.AppServices
{
    public class DeviceService: IDeviceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperService _mapper;

        public DeviceService(IUnitOfWork unitOfWork, IMapperService mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(InputDeviceDto deviceDto)
        {
            throw new NotImplementedException();
        }

        public void Update(InputDeviceDto deviceDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DeviceDto> GetAll()
        {
            var devices = _unitOfWork.Devices.GetAll();
            var devicesDto = _mapper.MapTo<IEnumerable<DeviceDto>>(devices);

            return devicesDto;
        }
    }
}
