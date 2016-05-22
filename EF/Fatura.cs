using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class Fatura
	{
		public long Id { get; set; }

		public ICollection<Ligacao> Ligacoes { get; set; }

	}
}
