using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoGalleryCore.Models;

namespace pages3.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly PhotoGalleryDbContext _context;

        public DetailsModel(PhotoGalleryDbContext context)
        {
            _context = context;
        }

        public Photo Photo { get; set; }
        public void OnGet(int photoid)
        {
            Photo = _context.Photos.Find(photoid);
        }
    }
}
