using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.App.AppServices
{
    public class AccountService: IAccountService
    {
        public AccountDto FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public AccountDto FindAccount(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
