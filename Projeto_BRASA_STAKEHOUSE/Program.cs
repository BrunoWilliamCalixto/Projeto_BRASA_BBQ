//using Projeto_BRASA_STAKEHOUSE.Entities;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Projeto_BRASA_STAKEHOUSE
//{
//	internal class Program
//	{
//		static Client client = new Client();
//		static bool IsClientRegistred = false;
//		static Order order = new Order();
//		static List<Product> products = new List<Product>
		
//			{
//				new Product("Churrasco de Picanha", 1, 100.00),
//				new Product("Churrasco de Maminha", 2, 80.00)
//			};

//		static void Main(string[] args)
//		{
//			Console.WriteLine("*******************Bem vindo ao BRASA BBQ - STAKEHOUSE*******************");
//			Console.WriteLine("-------------------------------------------------------------------------");


//			while (true)
//			{
//				if (!IsClientRegistred)
//				{
//					Console.WriteLine("Vamos começar o seu cadastro: ");
//					RegisterCustomer();
//					IsClientRegistred = true;
                    
//                }

//				Console.WriteLine("Digite abaixo a opção a ser selecionada: ");
//				Console.WriteLine("***************Menu***************");
//				Console.WriteLine("1 - Alterar Dados do Cliente" +
//								  "\n2 - Ver Cardápio" +
//								  "\n3 - Selecionar Itens" +
//								  "\n4 - Ver Carrinho" +
//								  "\n5 - Sair");

//				Console.Write("Selecione opção: ");
//				int option = int.Parse(Console.ReadLine());

//				switch (option)
//				{
//					case 1:
//						Console.WriteLine("Deseja realmente alterar o dados de usuário (s/n)? ");
//						char ch = char.Parse(Console.ReadLine().ToLower());
//						if(ch == 's')
//						{
//							RegisterCustomer();
//							Console.WriteLine("Usuário Alterado com sucesso!");
//							continue;
//						}
//						else
//						{
//							continue;
//						}
//					case 2:
//						SeeMenu();
//						continue;

//					case 3:
//						SelectItem();
//						continue;

//					case 4:
//						ViewCart();
					
//						continue;

//					case 5:
//						ExitProgram();
//						break;

//				}
//			}
//		}

//		public static void RegisterCustomer()
//		{
//			Console.WriteLine("-------------------------------------------------------------------------");
//			Console.Write("Digite seu nome: ");
//			string name = Console.ReadLine();
//			Console.Write("Digite seu cpf: ");
//			string cpf = Console.ReadLine();
//			Console.Write("Digite sua idade: ");
//			int yearOld = int.Parse(Console.ReadLine());
//			client = new Client(name, cpf, yearOld);

//		}
//		public static void SeeMenu()
//		{
//			Console.WriteLine("-------------------------------------------------------------------------");
//			Console.WriteLine("\t\t\t\tNosso Cardápio");
//			foreach (Product p in products)
//			{
//				Console.WriteLine($"Id Produto: {p.Id}, Nome: {p.NameProduct}, Preço: R${p.Price}");
//			}
//			Console.WriteLine("-------------------------------------------------------------------------");
//		}
//		public static void SelectItem()
//		{
		
//			Console.WriteLine("-------------------------------------------------------------------------");
//			Console.WriteLine("Selecione um produto:");
//			do
//			{
//				Console.Write("Índice do produto: ");
//				int index = int.Parse(Console.ReadLine());

//				// Adiciona o produto selecionado à ordem
//				Product selectedProduct = products[index - 1];
//				order.AddProductToOrder(selectedProduct);

//				Console.WriteLine($"Produto selecionado: {selectedProduct.NameProduct} " +
//					$"(ID: {selectedProduct.Id}, Preço: R${selectedProduct.Price})");

//				Console.Write("Deseja selecionar outro produto (s/n)? ");
//				char ch = char.Parse(Console.ReadLine().ToLower());
//				if (ch == 's')
//				{
//					continue;
//				}
//				else if (ch == 'n')
//				{
//					break;
//				}
//				else
//				{
//					Console.WriteLine("Comando inválido, tente novamente");
//					continue;
//				}

//			} while (true);
//			Console.WriteLine("-------------------------------------------------------------------------");
//		}
//		public static void ViewCart()
//		{
//			Console.WriteLine("-------------------------------------------------------------------------");
//			Console.WriteLine("\t\t\t\tSeu Carrinho");

//			foreach (Product p in order.Products)
//			{
//				Console.WriteLine($"Produto: {p.NameProduct} (ID: {p.Id}, Preço: R${p.Price})");
//			}

//			if (order.Products.Count == 0)
//			{
//				Console.WriteLine("Carrinho vazio");
//			}
//			else
//			{
//				Console.WriteLine("-------------------------------------------------------------------------");
//				Console.WriteLine("Deseja adicionar esses produtos ao seu carrinho?");
//				Console.WriteLine("1 - Sim");
//				Console.WriteLine("2 - Não");
//				Console.Write("Selecione opção: ");
//				int addToCartOption = int.Parse(Console.ReadLine());

//				if (addToCartOption == 1)
//				{
//					Cart cart = new Cart();
//					order.AddProductsToCart(cart);
//                    Console.WriteLine(cart);
//                }
//			}
//		}
//		public static void ExitProgram()
//		{
//			Console.WriteLine("Obrigado por utilizar nossos serviços");
//			Environment.Exit(0);
//		}
//	}
//}
