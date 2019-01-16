using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MfpStore.App.AppServices;
using MfpStore.App.AppServices.Dto;
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

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(DeviceViewModel deviceViewModel)
        {
            var deviceDto = _mapperService.MapTo<DeviceDto>(deviceViewModel);
            _deviceService.Add(deviceDto);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Update(Guid id)
        {
            var deviceDto = _deviceService.GetById(id);
            var deviceViewModel = _mapperService.MapTo<DeviceViewModel>(deviceDto);

            return View(deviceViewModel);
        }

        [HttpPost]
        public ActionResult Update(DeviceViewModel deviceViewModel)
        {
            var deviceDto = _mapperService.MapTo<DeviceDto>(deviceViewModel);
            _deviceService.Update(deviceDto);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            _deviceService.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }

       
    }
}