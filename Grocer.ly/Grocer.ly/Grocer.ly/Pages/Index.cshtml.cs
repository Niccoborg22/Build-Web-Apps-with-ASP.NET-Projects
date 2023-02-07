using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using GroceryStore.Models;

namespace GroceryStore.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public int Rating { get; set; }
        [BindProperty]
        public string Feedback { get; set; }

        public void OnGet()
        {

        }

    }
}