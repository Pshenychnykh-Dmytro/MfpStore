using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using MfpStore.App.AppServices;

namespace MfpStore.Web.Security
{
    public class UserProvider: IPrincipal
    {
        private readonly UserIdentity _userIdentity;

        public IIdentity Identity => _userIdentity;

        public UserProvider(string name, IAccountService accountService)
        {
            _userIdentity = new UserIdentity();
            _userIdentity.Init(name, accountService);
        }

        public bool IsInRole(string role)
        {
            if (_userIdentity.Account == null)
                return false;
            return _userIdentity.Account.InRole(role);
        }

        public override string ToString()
        {
            return _userIdentity.Name;
        }
    }
}