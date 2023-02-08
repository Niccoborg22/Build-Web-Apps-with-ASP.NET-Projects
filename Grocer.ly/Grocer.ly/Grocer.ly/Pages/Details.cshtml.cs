using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grocer.ly.Pages
{
    public class DetailsModel : PageModel
    {
        public GroceryItem CurrentFood { get; set; }

        public List<GroceryItem> Foods = Inventory.ToList();

        public async Task<IActionResult> OnGetAsync(string name)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
                await writer.WriteLineAsync($"{DateTime.Now} {name}");
            }
            CurrentFood = Foods.Find(food => food.Name == name);
            if (CurrentFood == null )
            {
                return NotFound();
            }
            return Page();
        }
    }
}
