using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicManager.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }

        /// <summary>
        /// Represents an album from an artist.
        /// </summary>
            public int AlbumId { get; set; }
            [Required, StringLength(50)]
            public string AlbumName { get; set; }

        /// <summary>
        /// Navigation property linking the song class to the album class.
        /// </summary>
        public virtual ICollection<Song> Songs { get; set; }
    }
}