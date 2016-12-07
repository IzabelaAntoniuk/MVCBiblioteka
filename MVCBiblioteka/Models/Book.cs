using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBiblioteka.Models
{
    public class Book
    {
        public int BookID { get; set; }
        [Required]
        [Display(Name = "Tytuł: ")]
        public string title { get; set; }
        [Required]
        [Display(Name = "Data premiery: ")]
        public DateTime premiereDate { get; set; }
        [Required]
        [Display(Name = "Wydawnictwo: ")]
        public int PublisherID { get; set; }
        [Required]
        [Display(Name = "Autor: ")]
        public int AuthorID { get; set; }
        [Required]
        [Display(Name = "Kategoria: ")]
        public int CategoryID { get; set; }
        [Required]
        [Display(Name = "Opis: ")]
        public string description { get; set; }
        [Required]
        [Display(Name = "Status książki: ")]
        public string state { get; set; }
        [Required]
        public string ISBN { get; set; }
        public int LendID { get; set; }

        public virtual ICollection<Publisher> Publishers { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Category> Category { get; set; }
    }
}