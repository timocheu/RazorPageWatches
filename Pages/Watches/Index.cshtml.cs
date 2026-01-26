using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using RazorPageWatches.Data;
using RazorPageWatches.Models;

namespace RazorPageWatches.Pages.Watches
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageWatches.Data.RazorPageWatchesContext _context;

        public IndexModel(RazorPageWatches.Data.RazorPageWatchesContext context)
        {
            _context = context;
        }

        public IList<Watch> Watch { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchModel { get; set; }

        public SelectList? Brand { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? WatchBrand { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> brandQuery = from m in _context.Watch
                                            orderby m.Brand
                                            select m.Brand;

            var watches = from m in _context.Watch select m;

            if (!string.IsNullOrEmpty(WatchBrand))
            {
                watches = watches.Where(x => x.Brand == WatchBrand);
            }

            if (!string.IsNullOrEmpty(SearchModel))
            {
                watches = watches.Where(s => s.Model.Contains(SearchModel));
            }

            Brand = new SelectList(await brandQuery.Distinct().ToListAsync());

            Watch = await watches.ToListAsync();
        }
    }
}
