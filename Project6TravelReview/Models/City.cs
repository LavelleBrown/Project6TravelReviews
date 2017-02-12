using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project6TravelReview.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}