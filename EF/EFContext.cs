using System.Data.Entity;

namespace EF
{
	class EFContext:DbContext
	{
		public DbSet<Editora> Editoras {get;set;}
	}
}