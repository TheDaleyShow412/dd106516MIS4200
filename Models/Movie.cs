using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dd106516MIS4200.Models
{
    public class Movie
    {
        public int movieID { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string movieTitle { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        [Display(Name = "Release")]
        public DateTime releaseDate { get; set; }

        public int actorID { get; set; }

        public int directorID { get; set; }

        public Actor actor { get; set; }

        public Director director { get; set; }
    }
}