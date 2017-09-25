using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [MovieValidation]
        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }

        public int? NumberAvailable { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public string Description { get; set; }

        public MovieImage MovieImage { get; set; }

        [Required]
        [Display(Name = "Image of movie")]
        public int? MovieImageId { get; set; }

    }
}