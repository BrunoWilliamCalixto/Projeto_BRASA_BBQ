using System;
using System.Collections.Generic;

namespace Projeto_BRASA_STAKEHOUSE.Entities
{
    internal class Cart
    {
        public List<Product> Products { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }

        public double TotalCart()
        {
            double total = 0.0;
            foreach (var product in Products)
            {
                total += product.Price;
            }


            if (total == 0.0)
            {
                throw new Exception("Error: Carrinho está vazio");
                
            }

            return total;
        }
        
    }
}


