using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.Web.Security
{
    public static class AccoundDtoExtension
    {
        public static bool InRole(this AccountDto accountDto, string role)
        {
            var accountRole = accountDto.Roles.FirstOrDefault(r => r.Name == role);

            return accountRole != null;
        }
    }
}