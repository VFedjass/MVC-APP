using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using entry.Models;

namespace entry.Data
{
    public class entryContext : DbContext
    {
        public entryContext (DbContextOptions<entryContext> options)
            : base(options)
        {
        }

        public DbSet<entry.Models.Client> Client { get; set; } = default!;

        public DbSet<entry.Models.Product> Product { get; set; } = default!;

        public DbSet<entry.Models.Order> Order { get; set; } = default!;
    }
}
