using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MfpStore.App.AppServices;
using MfpStore.App.AppServices.Dto;

namespace MfpStore.Web.Security
{
    public class Authentication: IAuthentication
    {
        private const int CookieVersion = 1;
        private const string CookieName = "__AUTH_COOKIE";
        private IPrincipal _currentUser;

        public IAccountService AccountService { get; set; }

        public HttpContext HttpContext { get; set; }

        public AccountDto Login(string login, string password, bool isPersistent)
        {
            var account = AccountService.FindAccount(login, password);

            if (account != null)
            {
                CreateCookie(login, isPersistent);
            }

            return account;
        }

        public void Logout()
        {
            var httpCookie = HttpContext.Response.Cookies[CookieName];

            if (httpCookie != null)
            {
                httpCookie.Value = string.Empty;
            }
        }

        private string CreateEncryptTicket(string userName, bool isPersistent)
        {
            var ticket = new FormsAuthenticationTicket(
                CookieVersion,
                userName,
                DateTime.UtcNow,
                DateTime.UtcNow.Add(FormsAuthentication.Timeout),
                isPersistent,
                string.Empty,
                FormsAuthentication.FormsCookiePath);

            return FormsAuthentication.Encrypt(ticket);
        }

        private void CreateCookie(string userName, bool isPersistent)
        {
            var authCookie = new HttpCookie(CookieName)
            {
                Value = CreateEncryptTicket(userName, isPersistent),
                Expires = DateTime.UtcNow.Add(FormsAuthentication.Timeout)
            };
            HttpContext.Response.SetCookie(authCookie);
        }

        public IPrincipal CurrentUser
        {
            get
            {
                if (_currentUser == null)
                {
                    try
                    {
                        HttpCookie authCookie = HttpContext.Request.Cookies.Get(CookieName);
                        if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                        {
                            var ticket = FormsAuthentication.Decrypt(authCookie.Value);
                            _currentUser = new UserProvider(ticket.Name, AccountService);
                        }
                        else
                        {
                            _currentUser = new UserProvider(null, null);
                        }
                    }
                    catch (Exception ex)
                    {
                        //logger.Error("Failed authentication: " + ex.Message);
                        _currentUser = new UserProvider(null, null);
                    }
                }
                return _currentUser;
            }

        }

    }
}