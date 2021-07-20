using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PhotoGalleryCore.Models;

namespace pages3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private PhotoGalleryDbContext _context;
        public IndexModel(ILogger<IndexModel> logger, PhotoGalleryDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Photo> Photos { get; set; } = new List<Photo>();

        public IActionResult  OnGet()
        {
            Photos = _context.Photos.Take(60);

            return Page();
        }
    }
}
