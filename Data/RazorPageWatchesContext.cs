using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageWatches.Models;

namespace RazorPageWatches.Data
{
    public class RazorPageWatchesContext : DbContext
    {
        public RazorPageWatchesContext (DbContextOptions<RazorPageWatchesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageWatches.Models.Watch> Watch { get; set; } = default!;
    }
}
