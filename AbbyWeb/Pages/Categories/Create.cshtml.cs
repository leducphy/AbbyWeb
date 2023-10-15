using AbbyWeb.Data;
using AbbyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace AbbyWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _context;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDBContext context)
        {
            _context = context;

        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "The Display Order can not exactly match the Name.");
            }
           
            if (ModelState.IsValid)
            {
                await _context.Categories.AddAsync(Category);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
