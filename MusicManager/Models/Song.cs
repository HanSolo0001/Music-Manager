using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicManager.Models
{
    /// <summary>
    /// This is the song of the music for the playlist, and will be logged into the Music Manager app.
    /// </summary>
    public class Song
    {
        public Song()
        {
            Album = new List<Album>();
        }

        /// <summary>
        ///  The Id of the song.
        /// </summary>
        public int SongId { get; set; }

        /// <summary>
        ///  The name of the song.
        /// </summary>
        public string SongName { get; set; }

        /// <summary>
        /// The artist of the song.
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        ///  The duration of the song.
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        ///  Whether or not this song should be excluded when calculating the total duration of the current playlist. 
        /// </summary>
        public bool Exclude { get; set; }

        /// <summary>
        /// Navigation property linking the album class to the song class.
        /// </summary>
        public virtual ICollection<Album> Album { get; set; }

        /// <summary>
        /// Navigation property linking the artist class to the song class.
        /// </summary>
        public virtual Artist Artist { get; set; }
    }
}