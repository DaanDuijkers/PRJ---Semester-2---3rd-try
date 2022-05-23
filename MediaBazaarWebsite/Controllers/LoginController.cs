using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite
{
    public class LoginController
    {
        [Required, BindProperty]
        public string Username { get; set; }
        [Required, BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        public LoginController() { }
    }
}