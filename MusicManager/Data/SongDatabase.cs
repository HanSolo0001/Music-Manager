using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MusicManager.Models;

namespace MusicManager
{
    public class SongDatabase : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        public SongDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SongDatabase>());
        }
    }
}