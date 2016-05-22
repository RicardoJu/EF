using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class AdicionaRevista
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				for (int i = 0; i < 15; i++){
					Revista revista = new Revista();
					revista.Nome = "Revista" + (i + 1);
					revista.Preco = 10.0 * (i + 1);
					ctx.Revistas.Add(revista);

				}
				ctx.SaveChanges();
			}

		}
	}
}
