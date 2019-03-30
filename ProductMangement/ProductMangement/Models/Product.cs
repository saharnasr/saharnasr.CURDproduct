using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductMangement.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string title { get; set; }
        [DisplayName ( "Category")]
        public string description { get; set; }
        public int price { get; set; }
    }
}