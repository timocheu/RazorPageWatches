using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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

        public async Task OnGetAsync()
        {
            Watch = await _context.Watch.ToListAsync();
        }
    }
}
