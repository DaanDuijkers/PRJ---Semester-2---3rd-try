using MediaBazaarClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite
{
    public class ProfileController
    {
        [Required, BindProperty, DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required, BindProperty]
        public Gender Gender { get; set; }
        [Required, BindProperty]
        public string FirstName { get; set; }
        [Required, BindProperty]
        public string LastName { get; set; }
        [Required, BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, BindProperty]
        public string Phone { get; set; }
        [Required, BindProperty]
        public string Email { get; set; }
        [Required, BindProperty]
        public string Postal { get; set; }
        [Required, BindProperty]
        public string ContactName { get; set; }
        [Required, BindProperty]
        public string ContactPhone { get; set; }

        public ProfileController() { }
    }
}