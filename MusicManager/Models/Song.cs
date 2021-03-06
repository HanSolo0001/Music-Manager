﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicManager.Models
{
    public class Song
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Song()
        { }

        /// <summary>
        ///  The Id of the song.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  The name of the song.
        /// </summary>
        [Required]
        [DisplayName("Song")]
        public string SongName { get; set; }

        /// <summary>
        /// The artist of the song.
        /// </summary>
        [Required, StringLength(100)]
        [DisplayName("Artist")]
        public string ArtistName { get; set; }

        /// <summary>
        /// Represents an album from an artist.
        /// </summary>
        [Required, StringLength(50)]
        [DisplayName("Album")]
        public string AlbumName { get; set; }

        /// <summary>
        ///  The duration of the song.
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        ///  Whether or not this song should be excluded when calculating the total duration of the current playlist. 
        /// </summary>
        public bool Exclude { get; set; }
    }
}