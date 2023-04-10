using Projeto_BRASA_STAKEHOUSE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BRASA_STAKEHOUSE
{
	internal class Program2
	{
		static bool IsClientRegistred = false;
		static Client clients = new Client();
		static List<Product> products = Product.GetInitialProducts();
		static Cart cart = new Cart(products, clients);
		static Order order = new Order();
		static void Main(string[] args)
		{
			Console.WriteLine("*******************Bem vindo ao BRASA BBQ - STAKEHOUSE*******************");
			Console.WriteLine("-------------------------------------------------------------------------");

			// Loop principal do programa
			while (true)
			{
				// Verifica se o cliente foi registrado. Se não, pede os dados do cliente
				if (!IsClientRegistred)
				{
					Console.WriteLine("Vamos começar o seu cadastro: ");
					RegisterCustomer();
					IsClientRegistred = true;
				}

				// Menu principal do programa
				Console.WriteLine("Digite abaixo a opção a ser selecionada: ");
				Console.WriteLine("***************Menu***************");
				Console.WriteLine("1 - Alterar Dados do Cliente" +
								  "\n2 - Ver Cardápio" +
								  "\n3 - Selecionar Itens" +
								  "\n4 - Ver Carrinho" +
								  "\n5 - Sair");

				Console.Write("Selecione opção: ");
				int option = int.Parse(Console.ReadLine());

				switch (option)
				{
					// Caso 1: Permite ao cliente alterar seus dados
					case 1:
						Console.WriteLine("Deseja realmente alterar o dados de usuário (s/n)? ");
						char ch = char.Parse(Console.ReadLine().ToLower());
						if (ch == 's')
						{
							RegisterCustomer();
							Console.WriteLine("Usuário Alterado com sucesso!");

							continue;
						}
						else
						{
							continue;
						}
					// Caso 2: Mostra o cardápio ao cliente
					case 2:
						SeeMenu();
						continue;
					// Caso 3: Permite ao cliente selecionar os itens desejados
					case 3:
						SelectItem();
						continue;
					// Caso 4: Mostra ao cliente o conteúdo de seu carrinho
					case 4:
						Console.Clear();
						ViewCart();
						continue;
					// Caso 5: Sai do programa
					case 5:
						ExitProgram();
						break;
				}
			}
		}

		// Método para cadastrar um cliente
		public static void RegisterCustomer()
		{
			Console.WriteLine("-------------------------------------------------------------------------");
			Console.Write("Digite seu nome: ");
			string name = Console.ReadLine();
			Console.Write("Digite seu cpf: ");
			string cpf = Console.ReadLine();
			Console.Write("Digite sua idade: ");
			int yearOld = int.Parse(Console.ReadLine());
			// Cria um objeto Client com os dados informados
			clients = new Client(name, cpf, yearOld);

			// adiciona uma validação para verificar se o cliente foi criado corretamente
			if (clients == null)
			{
				Console.WriteLine("Erro ao cadastrar o cliente. Tente novamente.");
				return;
			}
		}

		public static void SeeMenu()
		{
			// Exibe os produtos disponíveis
			Console.WriteLine("-------------------------------------------------------------------------");
			Console.WriteLine("PRODUTOS DISPONÍVEIS:");
			foreach (Product product in products)
			{
				Console.WriteLine(product);
			}
		}

		public static void SelectItem()
		{
			Console.WriteLine("-------------------------------------------------------------------------");
			Console.WriteLine("Selecione um produto:");
			do
			{
				Console.Write("Índice do produto: ");
				int index = int.Parse(Console.ReadLine());

				// Adiciona o produto selecionado à ordem
				Product selectedProduct = products[index - 1];
				cart.AddProductToOrder(selectedProduct);

				Console.WriteLine($"Produto selecionado: {selectedProduct.NameProduct} " +
					$"(ID: {selectedProduct.Id}, Preço: R${selectedProduct.Price})");

				Console.Write("Deseja selecionar outro produto (s/n)? ");
				char ch = char.Parse(Console.ReadLine().ToLower());
				if (ch == 's')
				{
					continue;
				}
				else if (ch == 'n')
				{
					break;
				}
				else
				{
					Console.WriteLine("Comando inválido, tente novamente");
					continue;
				}

			} while (true);

		}

		public static void ViewCart()
		{
			if (clients == null)
			{
				Console.WriteLine("Nenhum cliente registrado. Registre um cliente primeiro.");
				return;
			}

            Console.WriteLine(clients);
            Console.WriteLine(cart);
		}

		public static void ExitProgram()
		{
			Environment.Exit(0);
		}
	}
}
