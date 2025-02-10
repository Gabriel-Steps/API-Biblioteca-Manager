using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.ViewModels
{
    public class LivroDetailsViewModel
    {
        public LivroDetailsViewModel(int id, string titulo, string autor, string iSBN, int anoDePublicacao)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoDePublicacao = anoDePublicacao;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public string ISBN { get; set; }
        public int AnoDePublicacao { get; set; }
    }
}
