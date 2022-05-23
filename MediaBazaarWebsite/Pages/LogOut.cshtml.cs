using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {
            // @WAD:   to logout call the method HttpContext.SignOutAsync()
            HttpContext.SignOutAsync();

            return RedirectToPage("/Login");
        }
    }
}