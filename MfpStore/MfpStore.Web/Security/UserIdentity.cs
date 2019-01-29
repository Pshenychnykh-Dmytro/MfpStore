using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using MfpStore.App.AppServices;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.Web.Security
{
    public class UserIdentity: IIdentity
    {
        public AccountDto Account { get; private set; }

        public string AuthenticationType => typeof(AccountDto).ToString();

        public bool IsAuthenticated => Account != null;

        public string Name => Account?.Email;

        public void Init(string email, IAccountService accountService)
        {
            if (!string.IsNullOrEmpty(email))
            {
                Account = accountService.FindByEmail(email);
            }
        }
    }
}