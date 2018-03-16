using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Movie
    {

        public int ID { get; set; }
        [StringLength(60, MinimumLength =2)]
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        [StringLength(30)]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Director { get; set; }
    }

    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}