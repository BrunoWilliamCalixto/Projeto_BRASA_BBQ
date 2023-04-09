using System.Collections.Generic;

namespace Projeto_BRASA_STAKEHOUSE.Entities
{
    internal class Order
    {
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public void AddProductToOrder(Product product)
        {
            Products.Add(product);
        }

        public void AddProductsToCart(Cart cart)
        {
            cart.Products.AddRange(Products);
            Products.Clear();
        }
    }
}