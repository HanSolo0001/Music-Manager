using Music_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Music_Manager
{
    public class SongDatabase : DbContext
    {
        public DbSet<SongDatabase> Songs { get; set; }

        public SongDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SongDatabase>());
        }
    }

    /// <summary>
    /// This is the entry of the music for the playlist, and will be logged into the Music Manager app.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// This is the constructor for easily creating music entries into a playlist
        /// </summary>
        /// <param name="id">The Id for the entry.</param>
        /// <param name="artist">The name of the artist.</param>
        /// <param name="album">The name of the album the song is from.</param>
        /// <param name="song">The name of the song.</param>
        /// <param name="duration">The duration (in minutes) for the song (how long the song lasts).</param>
        /// <param name="exclude">This is to determine whether or not the song will be excluded when the total minutes on the playlist enty's home page are calculated.</param>
        public Song(int id, string name, string artist, string album, double duration, bool exclude = false)
        {
            Id = id;
            Name = name;
            Artist = artist;
            Album = album;
            Duration = duration;
            Exclude = exclude;
        }

        /// <summary>
        ///  The Id of the entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  The name of the artist/band for the entry.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        ///  The name of the album for the entry.
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        ///  The name of the song for the entry.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  The duration of the song for the entry.
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        ///  Whether or not this entry should be excluded when calculating the total duration of the current playlist 
        /// </summary>
        public bool? Exclude { get; set; }
    }
}