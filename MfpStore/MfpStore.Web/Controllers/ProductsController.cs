using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MfpStore.App.AppServices;
using MfpStore.Web.Models;

namespace MfpStore.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IDeviceService _deviceService;
        private readonly IMapperService _mapperService;

        public ProductsController(IDeviceService deviceService, IMapperService mapperService)
        {
            _deviceService = deviceService;
            _mapperService = mapperService;
        }

        // GET: Products
        public ActionResult Index()
        {
            var devicesDto = _deviceService.GetAll();
            var devicesViewModel = _mapperService.MapTo<IEnumerable<DeviceViewModel>>(devicesDto);

            return View(devicesViewModel);
        }
    }
}