using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class Departamento
	{
		public long Id { get; set; }

		public string Nome { get; set; }

		public ICollection<Funcionario> Funcionarios { get; set; }

	}
}
