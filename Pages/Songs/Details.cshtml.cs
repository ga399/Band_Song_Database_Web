using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Band_Song_Database_Web.Business;
using Band_Song_Database_Web.Models;

namespace Band_Song_Database_Web.Pages.Songs
{
    public class DetailsModel : PageModel
    {
        private readonly Band_Song_Database_Web.Models.Band_Song_Database_DataContext _context;

        public DetailsModel(Band_Song_Database_Web.Models.Band_Song_Database_DataContext context)
        {
            _context = context;
        }

        public Song Song { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Song = await _context.Song
                .Include(s => s.Album)
                .Include(s => s.MusicBand)
                .Include(s => s.Producer).FirstOrDefaultAsync(m => m.Id == id);

            if (Song == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
