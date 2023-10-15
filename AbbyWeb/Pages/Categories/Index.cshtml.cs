using AbbyWeb.Data;
using AbbyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _context;

        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Categories = _context.Categories;
        }
    }
}
