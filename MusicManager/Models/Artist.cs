using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicManager.Models
{
    public class Artist
    {
        public Artist()
        {
            Songs = new List<Song>();
        }

        /// <summary>
        /// Represents an artist for a song.
        /// </summary>
        public int ArtistId { get; set; }

        [Required, StringLength(100)]
        public string ArtistName { get; set; }

        /// <summary>
        /// Navigation property linking the song class to the artist class.
        /// </summary>
        public virtual ICollection<Song> Songs { get; set; }
    }
}