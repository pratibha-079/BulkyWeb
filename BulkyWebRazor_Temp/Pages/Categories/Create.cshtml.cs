using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]//so that it's bind and available in post handler
        //explicitly bind properties that we want to access on the post of the form
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Catagory created successfully";
            return RedirectToPage("Index");
        }
    }
}
