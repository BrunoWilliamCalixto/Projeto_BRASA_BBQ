using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BRASA_STAKEHOUSE.Entities
{
	// Classe interna Client que representa um cliente
	internal class Client
	{
		// Propriedade pública para o nome do cliente
		public string Name { get; set; }
		// Propriedade pública para o CPF do cliente
		public string Cpf { get; set; }
		// Propriedade pública para a idade do cliente
		public int YearsOld { get; set; }

		// Construtor padrão vazio
		public Client()
		{
		}
		// Construtor com parâmetros para inicializar as propriedades
		public Client(string name, string cpf, int yearsOld)
		{
			Name = name;
			Cpf = cpf;
			YearsOld = yearsOld;
		}

		// Sobrescrita do método ToString() para formatar a exibição do cliente
		public override string ToString()
		{
			return $"Nome: {Name}, CPF: {Cpf}, Idade: {YearsOld}";
		}
	}
}


