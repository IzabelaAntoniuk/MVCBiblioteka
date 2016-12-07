using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBiblioteka.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int BookID { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime deathDate { get; set; }
        public string description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}