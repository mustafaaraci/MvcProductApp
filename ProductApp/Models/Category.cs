using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class Category
    {
       public int CategoryId { get; set; }
       public string Name { get; set; } =  string.Empty;  //default durumu boş  dedik.
    }
}