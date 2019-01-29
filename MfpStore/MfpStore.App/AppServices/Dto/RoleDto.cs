using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.Models;

namespace MfpStore.App.AppServices.Dto
{
    public class RoleDto: BaseModel
    {
        public string Name { get; set; }

        public int AccountId { get; set; }
    }
}
