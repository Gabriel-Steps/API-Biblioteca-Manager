using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.ViewModels
{
    public class LivroViewModel
    {
        public LivroViewModel(int id, string titulo, string autor, string iSBN, int anoDePublicacao, bool disponivel)
        {
	    Id = id;
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoDePublicacao = anoDePublicacao;
	    Disponivel = disponivel;
        }
	
	public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoDePublicacao { get; set; }
	public bool Disponivel { get; set; }
    }
}
