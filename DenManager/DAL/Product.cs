using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DenManager.DAL
{
    public class Product
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage = "Musisz podać cenę!")]
        [Range(0.0, 20000.0)]
        public decimal Price { get; set; }

        public string PhotoPath { get; set; }

        [Required(ErrorMessage = "Towar musi mieć nazwę!")]
        public string Name { get; set; }

        public Product()
        {
        }

        public Product(decimal price, string photoPath, string name)
        {
            Price = price;
            PhotoPath = photoPath;
            Name = name;
        }
    }
}