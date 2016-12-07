﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBiblioteka.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public string UserID { get; set; }
        public int Quantity { get; set; }
        public DateTime lendDate { get; set; }
        public DateTime returnDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}