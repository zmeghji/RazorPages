using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class AddBookModel : PageModel
    {
        private readonly ILogger<AddBookModel> _logger;
        
        public AddBookModel(ILogger<AddBookModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        [BindProperty]
        public Book Book { get; set; }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ViewData.Add("Success", true);
            }
            return Page();
        }
    }
}
