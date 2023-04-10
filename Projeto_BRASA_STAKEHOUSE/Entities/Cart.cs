using Projeto_BRASA_STAKEHOUSE.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal class Cart : Order
{
   
    public List<Product> SelectedProducts { get; private set; }

	// Construtor da classe Cart que recebe uma lista de produtos e um objeto cliente como parâmetros e chama o construtor da classe base
	public Cart(List<Product> products, Client client) : base(products, client)
	{
		// Instancia a lista de produtos selecionados pelo cliente
		SelectedProducts = new List<Product>();
	}

	// Método que adiciona um produto à lista de produtos selecionados pelo cliente
	public void AddProductToOrder(Product product)
	{
		SelectedProducts.Add(product);
	}

	// Método que calcula o valor total da compra, somando o preço de cada produto selecionado
	public double CalculateOrderTotal()
	{
		double total = 0.0;

		foreach (var product in SelectedProducts)
		{
			total += product.Price;
		}

		return total;
	}

	// Sobrescreve o método ToString() para exibir os produtos selecionados pelo cliente e o valor total da compra
	public override string ToString()
	{
		// Cria uma instância de StringBuilder para criar a string de retorno
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Data da Comanda gerada: {DateTime.Now}");
		// Adiciona uma linha de título à string de retorno
		sb.AppendLine("Produtos selecionados:");
		// Adiciona cada produto selecionado à string de retorno, exibindo o nome, ID e preço do produto
		foreach (var p in SelectedProducts)
		{
			sb.AppendLine($"- {p.NameProduct} (Id: {p.Id}) - R${p.Price.ToString("F2", CultureInfo.InvariantCulture)}");
		}

		// Adiciona o valor total da compra à string de retorno
		sb.AppendLine($"Total: R${CalculateOrderTotal().ToString("F2", CultureInfo.InvariantCulture)}");

		// Retorna a string de retorno
		return sb.ToString();
	}
}