using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaBazaarClassLibrary;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite
{
    public class LoginModel : PageModel
    {
        public LoginManager LoginManager { get; set; }

        [BindProperty]
        public LoginController Login { get; set; }

        public LoginModel()
        {
            this.LoginManager = new LoginManager(new LoginWebsiteSQL());
        }

        public IActionResult OnPost(string? returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employee employee = LoginManager.Login(new Employee(this.Login.Username, this.Login.Password));

                    if (employee != null)
                    {
                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, employee.Username));
                        claims.Add(new Claim("id", employee.ID.ToString()));

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                        // Url.IsLocalUrl is to prevent Open Redirect Attacks
                        // See 'What is an Open Redirection Attack?' @ https://docs.microsoft.com/en-us/aspnet/mvc/overview/security/preventing-open-redirection-attacks)
                        if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }

                        return RedirectToPage("Index");
                    }
                }

                ModelState.AddModelError("InvalidCredentials", "Either the supplied username/password is invalid or you have been blocked");
                return Page();
            }
            catch
            {
                return Page();
            }
        }
    }
}