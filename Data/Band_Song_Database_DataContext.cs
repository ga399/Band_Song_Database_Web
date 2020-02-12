using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Band_Song_Database_Web.Business;

namespace Band_Song_Database_Web.Models
{
    //database connection which connects the Business classes with the database schema
    public class Band_Song_Database_DataContext : DbContext
    {
        public Band_Song_Database_DataContext (DbContextOptions<Band_Song_Database_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Band_Song_Database_Web.Business.Album> Album { get; set; }

        public DbSet<Band_Song_Database_Web.Business.MusicBand> MusicBand { get; set; }

        public DbSet<Band_Song_Database_Web.Business.Producer> Producer { get; set; }

        public DbSet<Band_Song_Database_Web.Business.Song> Song { get; set; }
    }
}
