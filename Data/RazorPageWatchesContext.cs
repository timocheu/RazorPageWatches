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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Watch>().HasData(
                new Watch { Id = 1, Model = "Watchless", Brand = "Rolex", Price = 4223M, ReleaseDate = DateTime.Now},
                new Watch { Id = 2, Model = "Timekeeper", Brand = "Omega", Price = 5599M, ReleaseDate = DateTime.Now },
                new Watch { Id = 3, Model = "ChronoMaster", Brand = "Tag Heuer", Price = 3150M, ReleaseDate = DateTime.Now },
                new Watch { Id = 4, Model = "Aqua Terra", Brand = "Omega", Price = 4975M , ReleaseDate = DateTime.Now },
                new Watch { Id = 5, Model = "Explorer", Brand = "Rolex", Price = 7800M, ReleaseDate = DateTime.Now },
                new Watch { Id = 6, Model = "Speedmaster", Brand = "Omega", Price = 5500M, ReleaseDate = DateTime.Now },
                new Watch { Id = 7, Model = "Submariner", Brand = "Rolex", Price = 9400M , ReleaseDate = DateTime.Now },
                new Watch { Id = 8, Model = "Carrera", Brand = "Tag Heuer", Price = 4200M, ReleaseDate = DateTime.Now },
                new Watch { Id = 9, Model = "Seamaster", Brand = "Omega", Price = 3800M, ReleaseDate = DateTime.Now },
                new Watch { Id = 10, Model = "Daytona", Brand = "Rolex", Price = 13500M, ReleaseDate = DateTime.Now }
                );
        }

        
    }
}
