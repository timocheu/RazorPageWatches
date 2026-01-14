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
    public class DetailsModel : PageModel
    {
        private readonly RazorPageWatches.Data.RazorPageWatchesContext _context;

        public DetailsModel(RazorPageWatches.Data.RazorPageWatchesContext context)
        {
            _context = context;
        }

        public Watch Watch { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var watch = await _context.Watch.FirstOrDefaultAsync(m => m.Id == id);
            if (watch == null)
            {
                return NotFound();
            }
            else
            {
                Watch = watch;
            }
            return Page();
        }
    }
}
