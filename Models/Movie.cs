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
        public Genre Genre { get; set; }
        [Display(Name ="Genre")]
        public short GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1, 20, ErrorMessage = "This field must be between 1 and 20.")]
        public byte InStock { get; set; }

    }
}