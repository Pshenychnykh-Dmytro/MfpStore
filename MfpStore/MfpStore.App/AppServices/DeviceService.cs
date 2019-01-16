using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.AppServices.Dto;
using MfpStore.App.Data;
using MfpStore.App.Models;

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

        public void Add(DeviceDto deviceDto)
        {
            var device = _mapper.MapTo<Device>(deviceDto);
            _unitOfWork.Devices.Add(device);
            _unitOfWork.SaveChanges();
        }

        public void Update(DeviceDto deviceDto)
        {
            var device = _mapper.MapTo<Device>(deviceDto);
            _unitOfWork.Devices.Update(device);
            _unitOfWork.SaveChanges();
        }

        public void DeleteById(Guid id)
        {
            _unitOfWork.Devices.Delete(d => d.Id == id);
            _unitOfWork.SaveChanges();
        }

        public DeviceDto GetById(Guid id)
        {
            var device = _unitOfWork.Devices.FirstOrDefault(d => d.Id == id);
            var deviceDto = _mapper.MapTo<DeviceDto>(device);

            return deviceDto;
        }

        public IEnumerable<DeviceDto> GetAll()
        {
            var devices = _unitOfWork.Devices.GetAll();
            var devicesDto = _mapper.MapTo<IEnumerable<DeviceDto>>(devices);

            return devicesDto;
        }
    }
}
