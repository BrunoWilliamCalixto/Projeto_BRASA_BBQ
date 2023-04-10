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
		public string NameProduct { get; set; } // Nome do Produto
		public int Id { get; set; } // Identificação do Produto
		public double Price { get; set; } // Preço do Produto

		public List<Product> ListProducts = new List<Product>(); // Lista de Produtos

		public Product() { } // Construtor Vazio

		public Product(string nameProduct, int id, double price) // Construtor com parâmetros
		{
			NameProduct = nameProduct;
			Id = id;
			Price = price;
		}

		public static List<Product> GetInitialProducts() // Método para obter os produtos iniciais
		{
			List<Product> ListProducts = new List<Product> // Instanciação de uma nova lista de produtos
            {
				new Product("Picanha", 1, 80.0), // Adicionando novo produto à lista
                new Product("Maminha", 2, 60.0) // Adicionando novo produto à lista
            };
			return ListProducts; // Retornando a lista de produtos
		}

		public override string ToString() // Método para retornar uma string formatada com informações dos produtos
		{
			List<Product> initialProducts = GetInitialProducts(); // Obtendo a lista de produtos iniciais
			StringBuilder sb = new StringBuilder(); // Instanciação de um StringBuilder
			foreach (Product p in initialProducts) // Loop pelos produtos iniciais
			{
				sb.AppendLine($"Id Produto: {p.Id}, Nome: {p.NameProduct}, Preço: R${p.Price}"); // Adicionando informações do produto ao StringBuilder
			}
			return sb.ToString(); // Retornando a string criada com informações dos produtos
		}
	}
}
