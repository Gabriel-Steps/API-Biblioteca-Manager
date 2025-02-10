using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Core.Entities
{
    public class Livro : BaseEntity
    {
        public Livro(string titulo, string autor, string iSBN, int anoDeLancamento)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoDeLancamento = anoDeLancamento;
            Disponivel = true;
        }

        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public string ISBN { get; set; }
        public int AnoDeLancamento { get; set; }
        public bool Disponivel {  get; set; }
    }
}
