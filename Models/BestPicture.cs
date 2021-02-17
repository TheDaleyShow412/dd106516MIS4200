using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dd106516MIS4200.Models
{
    public class BestPicture
    {
        public int bestPictureID { get; set; }

        public int movieID { get; set; }

        public string movieTitle { get; set; }

        public int eligibleYear { get; set; }

        public string winner { get; set; }

        public ICollection<Movie> Movie { get; set; }

    }
}