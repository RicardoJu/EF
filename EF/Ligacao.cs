using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class Ligacao
	{
		public long Id { get; set; }

		public int Duracao { get; set; }

		public Fatura Fatura { get; set; }

	}
}
