using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
	class AdicionaLivroAutor
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Autor autor = new Autor();
				System.Console.WriteLine("Digite o nome do autor:");
				autor.Nome = System.Console.ReadLine();

				Livro livro = new Livro();
				System.Console.WriteLine("Digite o nome do livro:");
				livro.Nome = System.Console.ReadLine();

				autor.Livros = new List<Livro>();
				livro.Autores = new List<Autor>();

				autor.Livros.Add(livro);
				livro.Autores.Add(autor);

				ctx.Livros.Add(livro);
				ctx.Autores.Add(autor);

				ctx.SaveChanges();
				System.Console.WriteLine("Autor cadastrado com id" + autor.Id);
				System.Console.WriteLine("Livro cadastradocom id" + livro.Id);

			}




		}


	}
}
