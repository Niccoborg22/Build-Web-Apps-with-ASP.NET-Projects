using System;
using System.Collections.Generic;

namespace GroceryStore.Models
{
    public static class Inventory
    {
        public static List<GroceryItem> ToList()
        {
            return new List<GroceryItem>
      {
        new GroceryItem(name: "Organic Honeycrisp Apple", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/apple.png", price: 2.99, desc: "Organic, delicious Honeycrisp Apple, grown and harvested at a local farm."),
        new GroceryItem(name: "Artichoke", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/artichoke.png", price: 3.49, desc: "Our green Artichokes are produced year round, the highest quality with the freshest taste."),
        new GroceryItem(name: "Aubergine", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/aubergine.png", price: 5.49, desc: "Mild, earthy-flavored Aubergine that has the most velvety texture inside."),
        new GroceryItem(name: "Hass Avocado", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/avocado.png", price: 3.99, desc: "Delicious Hass Avocados have a buttery texture and rich flavor. Ripe and ready to eat!"),
        new GroceryItem(name: "Turkey Bacon", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/bacon.png", price: 9.99, desc: "Meaty and guilt-free, hand-trimmed turkey bacon."),
        new GroceryItem(name: "Broccoli", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/broccoli.png", price: 4.99, desc: "Nutritious and low in calories! Fresh green Broccoli that has a satisfying crunch."),
        new GroceryItem(name: "Assorted Candy", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/candy.png", price: 0.99, desc: "Classic candies in a variety of flavors like lemon, orange, pineapple, raspberry and strawberry."),
        new GroceryItem(name: "Chili Pepper", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/chili-pepper.png", price: 1.99, desc: "Bright red, spicy Chili Peppers. Add heat to all of your favorite dishes."),
        new GroceryItem(name: "Crab", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/crab.png", price: 22.49, desc: "Always fresh, never frozen. Flaky and delicate crab for steaming or stewing."),
        new GroceryItem(name: "Chocolate Cupcake", imgsrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/cupcake.png", price: 5.99, desc: "Delicious chocolate cake with buttercream icing. Freshly made by a local bakery.")
      };
        }
    }
}
