using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.Models;

namespace MfpStore.App.AppServices.Dto
{
    public class DeviceDto: BaseModel
    {
        public string Title { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}
