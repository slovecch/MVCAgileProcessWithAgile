using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAgileProcessWithAgile.Models;

namespace MVCAgileProcessWithAgile.Data
{
    public class MVCAgileProcessWithAgileContext : DbContext
    {
        public MVCAgileProcessWithAgileContext (DbContextOptions<MVCAgileProcessWithAgileContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAgileProcessWithAgile.Models.Movie> Movie { get; set; } = default!;
    }
}
