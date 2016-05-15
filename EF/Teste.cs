namespace EF
{
	class Teste
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Editora e = new Editora
				{
					Nome = "K19",
					Email = "contato@K19.com.br"
				};

				
				ctx.Editoras.Add(e);

				ctx.SaveChanges();

			}
		}
	}
}