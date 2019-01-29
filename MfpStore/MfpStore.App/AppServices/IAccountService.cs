using System;
using System.Collections.Generic;
using System.Text;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.App.AppServices
{
    public interface IAccountService
    {
        AccountDto FindByEmail(string email);

        AccountDto FindAccount(string login, string password);
    }
}
