using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AuthorWebApp.Models;

namespace AuthorWebApp.Data
{
    public class AuthorWebAppContext : DbContext
    {
        public AuthorWebAppContext (DbContextOptions<AuthorWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<AuthorWebApp.Models.Author> Author { get; set; } = default!;
    }
}
