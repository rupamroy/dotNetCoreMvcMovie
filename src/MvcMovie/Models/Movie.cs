using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]        
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[A-Za-z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[A-Za-z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}
