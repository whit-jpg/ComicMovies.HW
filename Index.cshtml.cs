using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComicMovie.HW.Pages
{
    public class IndexModel : PageModel
    {
        public string[] EpicComicMovies { get; set; }
        public void OnGet()
        {
            EpicComicMovies = new string[] { "Captain America: Civil War", "Doctor Strange", "Spider-Man", "Black Panther" };
        }
    }
}
