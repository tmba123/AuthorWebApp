using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AuthorWebApp.Data;
using AuthorWebApp.Models;

namespace AuthorWebApp.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly AuthorWebApp.Data.AuthorWebAppContext _context;

        public IndexModel(AuthorWebApp.Data.AuthorWebAppContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
