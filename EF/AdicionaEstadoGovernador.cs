using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class AdicionaEstadoGovernador
	{
		static void Main(string[] args )
		{
			using(EFContext ctx = new EFContext())
			{
				Governador g = new Governador();
				System.Console.WriteLine("Digite o nome do governador");
				g.Nome = System.Console.ReadLine();

				Estado e = new Estado();
				System.Console.WriteLine("Digite o nome do estado");
				e.Nome = System.Console.ReadLine();

				e.Governador = g;

				ctx.Estados.Add(e);

				ctx.SaveChanges();

				System.Console.WriteLine("Governador cadastrado com id:" + g.Id);
				System.Console.WriteLine("Estado cadastrado com id:" + e.Id);




			}

		}



	}
}
