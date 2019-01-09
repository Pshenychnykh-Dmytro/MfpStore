using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MfpStore.App.Models;

namespace MfpStore.Web.Models
{
    public class DeviceViewModel: BaseModel
    {
        public string Title { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}