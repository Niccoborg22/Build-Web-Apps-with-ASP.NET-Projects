using System;
namespace GroceryStore.Models
{
    public class GroceryItem
    {
        public string Name { get; set; }
        public string ImageSrc { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }

        public GroceryItem(string name = "Not Found", string imgsrc = "/images/blank.png", double price = 0.0, string desc = "n/a")
        {
            Name = name;
            ImageSrc = imgsrc;
            Price = price;
            Desc = desc;
        }
    }
}
