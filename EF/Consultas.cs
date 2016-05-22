using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class Consultas
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				
				int contador = ctx.Revistas.Count();

				System.Console.WriteLine("Há" + contador + "Revista.\n");

								contador = ctx.Revistas.Count(x => x.Preco > 100);

				System.Console.WriteLine(
					"Há" + contador + "Revista com preco acima de 100.\n");

				
			    double soma = ctx.Revistas.Sum (x => x.Preco);

				System.Console.WriteLine(
					"A somados precos das revistas é" + soma + "\n");

				double precoMaximo = ctx.Revistas.Max(x => x.Preco);


				System.Console.WriteLine(
					"O preço da revista mais cara é " + precoMaximo + "\n");


				double media = ctx.Revistas.Average(x => x.Preco);


				System.Console.WriteLine(
					"A média dos preços das revistas é " + media + "\n");

				var revistas = ctx.Revistas;

				System.Console.WriteLine("Todas as revistas:");

				foreach (Revista revista in revistas)
				{

					System.Console.WriteLine("Id" + revista.Id);
					System.Console.WriteLine("Nome:" + revista.Nome);
					System.Console.WriteLine("Preco:" + revista.Preco);
					System.Console.WriteLine();

				}

				var revistasCaras = ctx.Revistas.Where(x => x.Preco > 100);

				System.Console.WriteLine("Revista com preco acima de 100: ");

				foreach ( Revista revista in revistasCaras )
				{
					System.Console.WriteLine("Id:" + revista.Id );
				    System.Console.WriteLine("Nome:" + revista.Nome );
					System.Console.WriteLine("Preço:" + revista.Preco );
					System.Console.WriteLine() ;
				}



			}
		}






	}
}
