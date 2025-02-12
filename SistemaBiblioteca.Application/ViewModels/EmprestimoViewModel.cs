using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.ViewModels
{
    public class EmprestimoViewModel
    {
        public EmprestimoViewModel(int id, int idUsuario, int idLivro, DateTime dataDoEmprestimo, DateTime dataDaDevolucao)
        {
            Id = id;
            IdUsuario = idUsuario;
            IdLivro = idLivro;
            DataDoEmprestimo = dataDoEmprestimo;
            DataDaDevolucao = dataDaDevolucao;
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataDoEmprestimo { get; set; }
        public DateTime DataDaDevolucao { get; set; }
    }
}
