using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class AdicionaPedidoConsumidor
	{
		static void Main (string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Consumidor c = new Consumidor();
				System.Console.WriteLine("Digite o nome do consumidor");
				c.Nome = System.Console.ReadLine();

				Pedido p = new Pedido();

				p.Consumidor = c;

				ctx.Pedidos.Add(p);

				ctx.SaveChanges();

				System.Console.WriteLine ("Consumidor cadastrado com id:" + c.Id);
			    System.Console.WriteLine ("Pedido cadastrado com id:" + p.Id);

			}
		}

	}
}
