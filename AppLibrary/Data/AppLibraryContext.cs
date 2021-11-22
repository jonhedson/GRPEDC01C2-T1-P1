using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppLibrary.Models;

namespace AppLibrary.Data
{
    public class AppLibraryContext : DbContext
    {
        public AppLibraryContext (DbContextOptions<AppLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<AppLibrary.Models.Book> Book { get; set; }
    }
}
