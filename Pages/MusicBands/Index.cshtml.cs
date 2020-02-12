using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Band_Song_Database_Web.Business;
using Band_Song_Database_Web.Models;

namespace Band_Song_Database_Web.Pages.MusicBands
{
    public class IndexModel : PageModel
    {
        private readonly Band_Song_Database_Web.Models.Band_Song_Database_DataContext _context;

        public IndexModel(Band_Song_Database_Web.Models.Band_Song_Database_DataContext context)
        {
            _context = context;
        }

        public IList<MusicBand> MusicBand { get;set; }

        public async Task OnGetAsync()
        {
            MusicBand = await _context.MusicBand.ToListAsync();
        }
    }
}
