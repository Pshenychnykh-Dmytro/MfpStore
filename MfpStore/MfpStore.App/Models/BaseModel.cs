using System;
using System.Collections.Generic;
using System.Text;

namespace MfpStore.App.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}
