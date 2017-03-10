using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicManager.Models
{
    public class AlbumSong
    {
        /// <summary>
        /// Represents a song on an album.
        /// </summary>
            public int SongId { get; set; }
            public int ArtistId { get; set; }
            public int AlbumId { get; set; }

            public Song Song { get; set; }
            public Artist Artist { get; set; }
            public Album Album { get; set; }
    }
}