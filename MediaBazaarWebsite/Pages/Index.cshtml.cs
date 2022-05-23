using MediaBazaarClassLibrary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ShiftManager shiftManager;
        [BindProperty]
        public DateController DateModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            DateTime dateTime = DateTime.Today;
            this.DateModel = new DateController(dateTime);

            this.shiftManager = new ShiftManager(new ShiftSQL());
        }

        public void OnGet(string date)
        {
            if (date != null)
            {
                this.DateModel = new DateController(DateTime.Parse(date));
            }
        }

        public IActionResult OnPostNext(string currentDate)
        {
            return RedirectToPage("Index", new
            {
                date = currentDate
            });
        }

        public IActionResult OnPostPrevious(string currentDate)
        {
            return RedirectToPage("Index", new
            {
                date = currentDate
            });
        }
    }
}