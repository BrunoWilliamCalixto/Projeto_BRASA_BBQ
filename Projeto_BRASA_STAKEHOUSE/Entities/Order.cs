using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Projeto_BRASA_STAKEHOUSE.Entities
{
    internal class Order
    {

		// Construtores da classe "Order"
		public List<Product> Products { get; set; }
        public Client Client { get; set; }

		public Order()
		{
		}
		public Order(List<Product> products, Client client)
		{
			Products = products;
			Client = client;
		}
	}
}