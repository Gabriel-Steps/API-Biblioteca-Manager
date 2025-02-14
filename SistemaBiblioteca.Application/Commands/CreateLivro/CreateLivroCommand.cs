using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.CreateLivro
{
    public class CreateLivroCommand : IRequest<int>
    {

	public CreateLivroCommand(string titulo, string autor, string isbn, int anoDeLancamento){
		Titulo = titulo;
		Autor = autor;
		ISBN = isbn;
		AnoDeLancamento = anoDeLancamento;
	}
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoDeLancamento { get; set; }
    }
}
