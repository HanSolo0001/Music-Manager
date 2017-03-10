using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicManager.Models
{
    public class Album
    {
        /// <summary>
        /// Represents an album from an artist.
        /// </summary>
            public int AlbumId { get; set; }
            [Required, StringLength(50)]
            public string Name { get; set; }
    }
}