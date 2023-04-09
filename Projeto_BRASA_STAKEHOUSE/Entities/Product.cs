using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BRASA_STAKEHOUSE.Entities
{
    public class Product
    {
        public string NameProduct { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }

        public List<Product> ListProducts = new List<Product>();

        public Product() { }

        public Product(string nameProduct, int id, double price)
        {
            NameProduct = nameProduct;
            Id = id;
            Price = price;
        }
        public void AddProduct(Product product)
        {
         ListProducts.Add(product);
        }
    }
}
