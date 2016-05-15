namespace EF
{
	class ListaEditorasComEF
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				foreach(Editora e in ctx.Editoras)
				{
					System.Console.WriteLine("Editora {0} - {1}", e.Nome, e.Email);
				}
			}
		}
	}
}