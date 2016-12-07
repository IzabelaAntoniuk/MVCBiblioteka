using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBiblioteka.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        [Required]
        [Display(Name = "Nazwa wydawnictwa: ")]
        public string name { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        public int BookID { get; set; }
        //public List<Book> Books { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}