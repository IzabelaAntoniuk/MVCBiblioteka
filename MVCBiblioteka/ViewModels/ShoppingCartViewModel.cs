using MVCBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBiblioteka.ViewModels
{
    public class ShoppingCartViewModel
    {
        public string ShoppingCartViewModelID { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}