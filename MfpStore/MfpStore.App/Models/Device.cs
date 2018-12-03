using System;
using System.Collections.Generic;
using System.Text;

namespace MfpStore.App.Models
{
    public class Device: BaseModel
    {
        public string Title { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}
