using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MfpStore.App.AppServices.Dto;
using MfpStore.App.Models;
using MfpStore.Web.Models;

namespace MfpStore.Web.Util
{
    public class AutoMapperConfig
    {
        public static void ConfigureMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Device, DeviceDto>().ReverseMap();
                cfg.CreateMap<DeviceDto, DeviceViewModel>().ReverseMap();
            });
        }
    }
}