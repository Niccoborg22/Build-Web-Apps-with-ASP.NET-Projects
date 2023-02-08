using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grocer.ly.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public int Rating { get; set; }
        [BindProperty]
        public string Feedback { get; set; }

        public List<GroceryItem> Foods = Inventory.ToList();

        public void OnGet()
        {

        }
    }
}
