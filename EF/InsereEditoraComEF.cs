namespace EF
{
	class InsereEditoraComEF
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Editora e = new Editora();
				System.Console.Write("Digite o Nome da Editora:");
				e.Nome = System.Console.ReadLine();

				System.Console.Write("Digite o Email da Editora:");
				e.Email = System.Console.ReadLine();

				ctx.Editoras.Add(e);

				ctx.SaveChanges();

				System.Console.WriteLine("Editora Cadastrada com Id:" + e.Id);
			}
		}
	}
}