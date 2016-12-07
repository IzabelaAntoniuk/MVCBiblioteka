using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBiblioteka.Models
{
    public class Address
    {
       // [Key, ForeignKey("Employee")]
        public int AddressID { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string code { get; set; }
        public string country { get; set; }
        public string UserID { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }
    }
}