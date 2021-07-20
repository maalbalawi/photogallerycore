using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PhotoGalleryCore.Models;
using System.IO;
namespace pages3.Pages
{
    public class BufferedInputModel
    {
        public IFormFile FormFile { get; set; }
        public Photo Photo { get; set; }
    }

    public class Upload : PageModel
    {
        private readonly PhotoGalleryDbContext _context;
        private readonly IWebHostEnvironment _env;

        //  private readonly ILogger<Upload> _logger;


        [BindProperty]
        public BufferedInputModel InputModel { get; set; }

        public Upload(PhotoGalleryDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            //_logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostUploadAsync()
        {
            ;
            if (!ModelState.IsValid)
                return NotFound();

            string dirname = DateTime.Now.ToString("yyyy-dd");
            DirectoryInfo directoryInfo = new DirectoryInfo(System.IO.Path.Combine(_env.WebRootPath, dirname));
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            try
            {
                string filename = System.IO.Path.Combine(_env.WebRootPath, dirname, InputModel.FormFile.FileName);

                var k = System.IO.File.OpenWrite(filename);

                InputModel.FormFile.CopyTo(k);
                k.Close();

                InputModel.Photo.Path = System.IO.Path.Combine(dirname, InputModel.FormFile.FileName); ;
                _context.Add(InputModel.Photo);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            catch (Exception e)
            {
                return Page();
            }
        }


    }
}

