using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class AdicionaFaturaLigacao
	{
		static void Main(string[] args)
		{
			using (EFContext ctx = new EFContext())
			{
				
				Ligacao ligacao1 = new Ligacao();
				System.Console.WriteLine("Digite o tempo de duração da primeira ligação: ");
				ligacao1.Duracao = System.Convert.ToInt32(System.Console.ReadLine());

				Ligacao ligacao2 = new Ligacao();
				System.Console.WriteLine("Digite o tempo de duração da segunda ligação: ");
				ligacao2.Duracao = System.Convert.ToInt32(System.Console.ReadLine());				

				Fatura fatura = new Fatura();
				fatura.Ligacoes = new List<Ligacao>();
				
				ligacao1.Fatura = fatura;
				ligacao2.Fatura = fatura;

				fatura.Ligacoes.Add(ligacao1);
				fatura.Ligacoes.Add(ligacao2);
				
				ctx.Ligacoes.Add(ligacao1);
				ctx.Ligacoes.Add(ligacao2);
				ctx.Faturas.Add(fatura);
				
				ctx.SaveChanges();
				
				System.Console.WriteLine("Primeira ligação cadastrada com id: " + ligacao1.Id);
				System.Console.WriteLine("Segunda ligação cadastrada com id: " + ligacao2.Id);
				System.Console.WriteLine("Fatura cadastrada com id: " + fatura.Id);
			}
		}
	}
}









