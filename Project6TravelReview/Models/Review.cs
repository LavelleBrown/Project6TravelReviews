using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project6TravelReview.Models
{
    public class Review
    {

        [Key]
        public int ID { get; set; }
        public int Hotels { get; set; }
        public int Dining { get; set; }
        public int Entertainment { get; set; }
        public int Attractions { get; set; }
        public bool Recommend { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("City")]
        public int CityID { get; set; }
        public virtual City City { get; set; }
    }
}