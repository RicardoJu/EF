using System.Data.Entity;

namespace EF
{
	class EFContext:DbContext
	{
		public DbSet<Editora> Editoras {get;set;}
		public DbSet<Cliente> Clientes { get; set; }

		public EFContext()
		{
			DropCreateDatabaseIfModelChanges<EFContext> initializer =
				new DropCreateDatabaseIfModelChanges<EFContext>();
			Database.SetInitializer<EFContext>(initializer);
		}
	}
}