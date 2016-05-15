namespace EF
{
	class InsereClienteComEF
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Cliente c = new Cliente();

				System.Console.Write("Digite o Nome do Cliente:");
				c.Nome = System.Console.ReadLine();

				System.Console.Write("Digite o Cpf do Cliente:");
				c.Cpf = System.Console.ReadLine();

				Endereco e = new Endereco();

				c.Endereco = e;

				System.Console.WriteLine("Digite o Nome do Cliente:");

				System.Console.Write("Pais:");
				e.Pais = System.Console.ReadLine();

				System.Console.Write("Estado:");
				e.Pais = System.Console.ReadLine();

				System.Console.Write("Cidade:");
				e.Pais = System.Console.ReadLine();

				System.Console.Write("Logradouro:");
				e.Pais = System.Console.ReadLine();

				System.Console.Write("Numero:");
				e.Pais = System.Console.ReadLine();

				System.Console.Write("Complemento:");
				e.Pais = System.Console.ReadLine();

				System.Console.Write("Cep:");
				e.Pais = System.Console.ReadLine();

				ctx.Clientes.Add(c);

				ctx.SaveChanges();

				System.Console.WriteLine("Cliente cadastrado com id:" + c.Id);




			}
		}
	}
}