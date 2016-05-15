using System;

namespace EF
{
	class RemoveEditoraComEF
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Console.Write("Digite o Id da Editora que deseja remover:");
				long id = Convert.ToInt64(Console.ReadLine());

				Editora e = ctx.Editoras.Find(id);

				ctx.Editoras.Remove(e);

				ctx.SaveChanges();
			}
		}
	}
}