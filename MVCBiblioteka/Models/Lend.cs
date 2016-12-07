using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBiblioteka.Models
{
    public class Lend
    {
        public int LendID { get; set; }
        public DateTime lendDate { get; set; }
        public DateTime returnDate { get; set; }
        public int BookID { get; set; }
        public string UserID { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Book Book { get; set; }
    }
}