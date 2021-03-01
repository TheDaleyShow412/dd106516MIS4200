using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dd106516MIS4200.Models
{
    public class Actor
    {
       public int actorID { get; set; }
        [Required]
        [Display (Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Age")]
        public int actorAge { get; set; }
        [Display(Name = "Oscar Winner?")]
        public string oscarWinner { get; set; }
        [Display(Name = "Actor")]
        public string actorName {
            get 
            {
                return lastName + ", " + firstName; 
            }
        }
        public ICollection<Movie> Movie { get; set; }

    }
}