using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;


namespace RazorPagesMovie.Pages_Movies
{


   public class ReviewModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieContext _context;
        [BindProperty]
        public Review Review { get; set; }
         
        public SelectList MoviesDropDown {get; set;}

        public ReviewModel(RazorPagesMovieContext context)
        {
            _context = context;
        }
        // public void OnGet()
        // {
        //    Movie= _context.Movie.ToList();
        //    MoviesDropDown = new SelectList(Movie,"ID","Title");
        //  }
    
        // public async Task<IActionResult> OnPostAsync()
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return Page();
        //     }

        //     _context.Movie.Include(s=>s.Review).Add(Movie);
        //     await _context.SaveChangesAsync();

        //     return RedirectToPage("./Index");
        // }
        
       
    }
}