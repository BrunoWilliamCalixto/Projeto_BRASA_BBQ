using Projeto_BRASA_STAKEHOUSE.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BRASA_STAKEHOUSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Order order = new Order();
            List<Product> products = new List<Product>();
            products.Add(new Product("Churrasco de Picanha", 1, 100.00));
            products.Add(new Product("Churrasco de Maminha", 2, 80.00));

            Console.WriteLine("*******************Bem vindo ao BRASA BBQ - STAKEHOUSE*******************");
            Console.WriteLine("-------------------------------------------------------------------------");


            while (true)
            {
                Console.WriteLine("Digite abaixo a opção a ser selecionada: ");
                Console.WriteLine("***************Menu***************");
                Console.WriteLine("1 - Cadastrar Cliente" +
                                  "\n2 - Ver Cardápio" +
                                  "\n3 - Selecionar Itens" +
                                  "\n4 - Ver Carrinho" +
                                  "\n5 - Sair");

                Console.Write("Selecione opção: ");
                int option = int.Parse(Console.ReadLine());

                switch (option){
                    case 1:
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("Bem vindo a seleção de cadastro! Vamos Começar...");
                        Console.Write("Digite seu nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Digite seu cpf: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Digite sua idade: ");
                        int yearOld = int.Parse(Console.ReadLine());

                        Client client = new Client(name, cpf, yearOld);
                        continue;

                    case 2:
                        
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("\t\t\t\tNosso Cardápio");
                        foreach(Product p in products)
                        {
                            Console.WriteLine($"Id Produto: {p.Id}, Nome: {p.NameProduct}, Preço: R${p.Price}");
                        }
                        Console.WriteLine("-------------------------------------------------------------------------");
                        continue;

                    case 3:
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("Selecione um produto:");
                        do
                        {
                            Console.Write("Índice do produto: ");
                            int index = int.Parse(Console.ReadLine());

                            // Adiciona o produto selecionado à ordem
                            Product selectedProduct = products[index - 1];
                            order.AddProductToOrder(selectedProduct);

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
                        Console.WriteLine("-------------------------------------------------------------------------");
                        continue;

                    case 4:
                        try
                        {
                            Console.WriteLine("-------------------------------------------------------------------------");

                            Console.WriteLine("\t\t\t\tSeu Carrinho");
                            if (product.Price == 0)
                            {
                                Console.WriteLine();
                            }

                            foreach (Product p in order.Products)
                            {
                                Console.WriteLine($"Produto: {p.NameProduct} (ID: {p.Id}, Preço: R${p.Price})");
                            }


                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine("Deseja adicionar esses produtos ao seu carrinho?");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("2 - Não");
                            Console.Write("Selecione opção: ");
                            int addToCartOption = int.Parse(Console.ReadLine());

                            if (addToCartOption == 1)
                            {
                                Cart cart = new Cart();
                                order.AddProductsToCart(cart);
                                Console.WriteLine("Produtos adicionados ao carrinho!");
                                Console.WriteLine("Total: " + cart.TotalCart());
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro: " + ex.Message);
                        }

                        continue;

                    case 5:
                        Console.WriteLine("Obrigado por utilizar nossos serviços");
                        break;
                }

                Console.Clear();

                if (option == 5)
                {
                    break;
                }

               
            }
        }
    }
}
