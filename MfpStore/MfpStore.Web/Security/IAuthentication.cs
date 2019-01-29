using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MfpStore.App.AppServices;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.Web.Security
{
    public interface IAuthentication
    {
        HttpContext HttpContext { get; set; }

        IAccountService AccountService { get; set; }

        AccountDto Login(string login, string password, bool isPersistent);

        void Logout();

        IPrincipal CurrentUser { get; }
    }
}
