
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill in your name")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please Choose a genre")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required(ErrorMessage = "Stock must be between 1 and 20")]
        [Range(0, 20)]
        public byte NumberInStock { get; set; }
    }
}