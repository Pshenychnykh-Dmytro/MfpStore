using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.Models;

namespace MfpStore.App.AppServices.Dto
{
    public class AccountDto: BaseModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public List<RoleDto> Roles { get; set; }
    }
}
