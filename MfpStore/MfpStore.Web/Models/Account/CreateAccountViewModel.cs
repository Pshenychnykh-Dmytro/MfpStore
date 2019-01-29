using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MfpStore.Web.Models.Account
{
    public class CreateAccountViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}