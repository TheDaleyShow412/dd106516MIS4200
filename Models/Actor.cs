using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dd106516MIS4200.Models
{
    public class Actor
    {
       public int actorID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int actorAge { get; set; }

        public string oscarWinner { get; set; }

        public string fullName {
            get 
            {
                return lastName + ", " + firstName; 
            }
        }
        public ICollection<Movie> Movie { get; set; }

    }
}