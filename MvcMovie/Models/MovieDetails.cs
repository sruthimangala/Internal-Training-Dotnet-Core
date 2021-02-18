using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public Movie Movie { get; set; }
    }
}