using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }
        [Display(Name="Ürün Adı")]
        public string Name { get; set; }
        [Display(Name="Ürün Fiyatı")]
        public double Price { get; set; }
        [Display(Name="Ürün Resmi")]
        public string Image { get; set; }
        [Display(Name="Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name="Kategori")]
        public int CategoryId { get; set; }
    }
}