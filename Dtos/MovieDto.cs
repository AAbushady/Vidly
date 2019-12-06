using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public short GenreId { get; set; }

        public DateTime? ReleaseDate { get; set; }
        
        public DateTime? DateAdded { get; set; }

        [Range(1, 20, ErrorMessage = "This field must be between 1 and 20.")]
        public byte InStock { get; set; }
    }
}