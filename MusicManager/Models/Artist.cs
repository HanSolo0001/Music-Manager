using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicManager.Models
{
    public class Artist
    {
        /// <summary>
        /// Represents an artist for a song.
        /// </summary>
        public int ArtistId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}