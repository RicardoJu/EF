using System;

namespace EF
{
	class AlteraEditoraComEF
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Console.Write("Digite o Id da Editora que deseja alterar:");
				long id = Convert.ToInt64(Console.ReadLine());

				Editora e = ctx.Editoras.Find(id);

				Console.Write("Digite o novo Nome da Editora:");
				e.Nome = Console.ReadLine();

				Console.Write("Digite o novo E-mail da Editora:");
				e.Email = Console.ReadLine();

				ctx.SaveChanges();

	
			}
		}
	}
}