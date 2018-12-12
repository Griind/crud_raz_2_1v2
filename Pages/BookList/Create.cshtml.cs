using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_Razor_2_1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Crud_Razor_2_1.Pages.Create
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        [BindProperty]
        public Book Book { get; set; }
        public CreateModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();
            _dbContext.Books.Add(Book);
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}