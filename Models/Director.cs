using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dd106516MIS4200.Models
{
    public class Director
    {
        [Display(Name = "First Name")]
        [Required]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string lastName { get; set; }
        [Display(Name = "Director Name")]
        public string directorName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }

        public int directorID { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime directorBirthDate { get; set; }
        [Display(Name = "Oscar Winner?")]
        public string OscarWinner { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}