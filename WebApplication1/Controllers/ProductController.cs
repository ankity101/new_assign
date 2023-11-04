using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApplication1.DbConnection;
using WebApplication1.Models;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductModel product)
    {
        if (ModelState.IsValid)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }


    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    [HttpPost]
    public IActionResult Search(string productName, string size, string price, string category, string conjunction)
    {
        var query = _context.Products.AsQueryable();

        if (!string.IsNullOrEmpty(productName))
        {
            query = conjunction switch
            {
                "OR" => query.Where(p => p.ProductName.Contains(productName)),
                _ => query.Where(p => p.ProductName == productName)
            };
        }

        if (!string.IsNullOrEmpty(size))
        {
            query = conjunction switch
            {
                "OR" => query.Where(p => p.ProductSize == Enum.Parse<Size>(size)),
                _ => query.Where(p => p.ProductSize == Enum.Parse<Size>(size))
            };
        }

        if (!string.IsNullOrEmpty(price))
        {
            query = conjunction switch
            {
                "OR" => query.Where(p => p.ProductPrice == Enum.Parse<Price>(price)),
                _ => query.Where(p => p.ProductPrice == Enum.Parse<Price>(price))
            };
        }

        if (!string.IsNullOrEmpty(category))
        {
            query = conjunction switch
            {
                "OR" => query.Where(p => p.ProductCategory == Enum.Parse<Category>(category)),
                _ => query.Where(p => p.ProductCategory == Enum.Parse<Category>(category))
            };
        }

        var searchResults = query.ToList();
        return View("Index", searchResults);
    }
}
