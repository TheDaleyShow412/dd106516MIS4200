using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dd106516MIS4200.Models
{
    public class Movie
    {
        public int movieID { get; set; }

        public string movieTitle { get; set; }

        public string description { get; set; }

        public int releaseDate { get; set; }

        public int actorID { get; set; }

        public int bestPictureID { get; set; }

        public virtual Actor actor { get; set; }

        public virtual BestPicture bestPicture { get; set; }
    }
}