using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MusicManager.Models;

namespace MusicManager.Context
{
    public class SongDatabase : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public SongDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SongDatabase>());
        }
    }
}