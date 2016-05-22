using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class Livro
	{
		public long Id { get; set; }

		public string Nome { get; set; }

		public ICollection<Autor> Autores { get; set; }
		

	}
}
