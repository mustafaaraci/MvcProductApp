using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductApp.Models;

namespace ProductApp.Controllers;

public class HomeController : Controller
{
       public IActionResult Index(string searchString,string category)
    {
        var products = Repository.Products;
        
        if(!String.IsNullOrEmpty(searchString)){
            ViewBag.SearchString = searchString;
            products = products.Where(p => p.Name.ToLower().Trim().Contains(searchString)).ToList();
        }
        
        if(!String.IsNullOrEmpty(category) && category != "0"){
            products =  products.Where(p => p.CategoryId ==int.Parse(category)).ToList();
        }

        //value olarak categoryıd yi al görünen olarak name mi al
        ViewBag.Categories = new  SelectList(Repository.Categories,"CategoryId","Name",category);

        return View(products);

    }

    public IActionResult Privacy()
    {
        return View();
    }

}
