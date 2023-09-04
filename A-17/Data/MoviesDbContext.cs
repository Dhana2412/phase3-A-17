using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using A_17.Models;

namespace A_17.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<A_17.Models.Movie> Movie { get; set; } = default!;
    }
}
