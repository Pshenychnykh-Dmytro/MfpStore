using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MfpStore.App.Models;
using MfpStore.Web.App_LocalResources;
using MfpStore.Web.App_LocalResources.Products;
using MfpStore.Web.Controllers;

namespace MfpStore.Web.Models
{
    public class DeviceViewModel: BaseModel
    {
        [Display(ResourceType = typeof(ProductsRes), Name = nameof(Title))]
        public string Title { get; set; }

        [Display(ResourceType = typeof(ProductsRes), Name = nameof(Price))]
        public float Price { get; set; }

        [Display(ResourceType = typeof(ProductsRes), Name = nameof(Description))]
        public string Description { get; set; }

        [Display(ResourceType = typeof(ProductsRes), Name = nameof(Picture))]
        public byte[] Picture { get; set; }
    }
}