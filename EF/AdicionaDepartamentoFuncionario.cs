using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class AdicionaDepartamentoFuncionario
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Funcionario f1 = new Funcionario();
				System.Console.WriteLine("Digite o nome do primeiro funcionario:");
				f1.Nome = System.Console.ReadLine();

				Funcionario f2 = new Funcionario();
				System.Console.WriteLine("Digite o nome do segundo funcionario:");
				f2.Nome = System.Console.ReadLine();

				Departamento d = new Departamento();
				System.Console.WriteLine("Digite o nome do departamento:");
				d.Nome = System.Console.ReadLine();

				d.Funcionarios = new List<Funcionario>();

				d.Funcionarios.Add(f1);
				d.Funcionarios.Add(f2);

				ctx.Departamentos.Add(d);

				ctx.SaveChanges();

				System.Console.WriteLine("Primeiro funcionario cadastrado no id:" + f1.Id);
				System.Console.WriteLine("Segundo funcionario cadastrado no id:" + f2.Id);
				System.Console.WriteLine("Departamento cadastrado no id:" + d.Id);

			}
		}
				
	}
}
