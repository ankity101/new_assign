using System;

namespace WebApplication1.Models
{
    public enum Size
    {
        Large,
        Medium,
        Small
    }

    public enum Price
    {
        Standard,
        Premium ,
        Economy 
    }

    public enum Category
    {
        Standard,
        Premium,
        Economy
    }

    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Size ProductSize { get; set; }
        public Price ProductPrice { get; set; }
        public DateTime MfgDate { get; set; }
        public Category ProductCategory { get; set; }
        // Add other properties here
    }
}
