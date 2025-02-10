using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Core.Entities
{
    public class Emprestimo : BaseEntity
    {
        public Emprestimo(int idLivro, int idUsuario)
        {
            IdLivro = idLivro;
            IdUsuario = idUsuario;

            DataDeEmprestimo = DateTime.Today;
            DataDeDevolucao = DateTime.Today.AddDays(20);
        }
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataDeEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }
    }
}
