using System.Data.Entity;

namespace EF
{
	class EFContext:DbContext
	{
		public DbSet<Editora> Editoras {get;set;}
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Estado> Estados { get; set; }
		public DbSet<Governador> Governadores { get; set; }
		public DbSet<Funcionario> Funcionarios { get; set; }
		public DbSet<Departamento> Departamentos { get; set; }
		public DbSet<Consumidor> Consumidores { get; set; }
		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<Autor> Autores { get; set; }
		public DbSet<Livro> Livros { get; set; }
		public DbSet<Ligacao> Ligacoes { get; set; }
		public DbSet<Fatura> Faturas { get; set; }


		public EFContext()
		{
			DropCreateDatabaseIfModelChanges<EFContext> initializer =
				new DropCreateDatabaseIfModelChanges<EFContext>();
			Database.SetInitializer<EFContext>(initializer);
		}
	}
}