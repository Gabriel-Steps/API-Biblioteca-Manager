using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.CreateEmprestimo
{
    public class CreateEmprestimoCommand : IRequest<int>
    {
        public CreateEmprestimoCommand(int idLivro, int idUsuario)
        {
            IdLivro = idLivro;
            IdUsuario = idUsuario;
        }

        public int IdLivro { get; set; }
        public int IdUsuario { get; set; }
    }
}
