using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaBazaarClassLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        public EmployeeManager employeeManager = new EmployeeManager(new EmployeeSQL());
        [BindProperty]
        public ProfileController ProfileController { get; set; }

        public void OnGet ()
        {
            this.ProfileController = new ProfileController();

            Employee employee = this.employeeManager.Get(new EmployeeGetByID(Convert.ToInt32(User.FindFirst("id").Value)));
            this.ProfileController.Gender = employee.Gender;
            this.ProfileController.FirstName = employee.FirstName;
            this.ProfileController.LastName = employee.LastName;
            this.ProfileController.Password = employee.Password;
            this.ProfileController.Phone = employee.Phone;
            this.ProfileController.Email = employee.Email;
            this.ProfileController.Postal = employee.Postal;
            this.ProfileController.ContactName = employee.ContactName;
            this.ProfileController.ContactPhone = employee.ContactPhone;
            this.ProfileController.BirthDate = employee.BirthDate;
        }

        public IActionResult OnPost ()
        {
            try
            {
                Employee employee = this.employeeManager.Get(new EmployeeGetByID(Convert.ToInt32(User.FindFirst("id").Value)));

                this.employeeManager.Update(new EmployeeGetEdit(employee, new Employee(employee.ID,
                    employee.BSN,
                    employee.WorkingHours,
                    employee.Position,
                    employee.Salary,
                    employee.IsActive,
                    this.ProfileController.BirthDate,
                    employee.HireDate,
                    this.ProfileController.Gender,
                    this.ProfileController.FirstName,
                    this.ProfileController.LastName,
                    this.ProfileController.Password,
                    this.ProfileController.Phone,
                    this.ProfileController.Email,
                    this.ProfileController.Postal,
                    this.ProfileController.ContactName,
                    this.ProfileController.ContactPhone
                    )));

                return Page();
            }
            catch
            {
                return RedirectToPage("Profile");
            }
        }
    }
}