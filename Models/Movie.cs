using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public short GenreId { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public DateTime? DateAdded { get; set; }
        [Required]
        public byte InStock { get; set; }

    }
}