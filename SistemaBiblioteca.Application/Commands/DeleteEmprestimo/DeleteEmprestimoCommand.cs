using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.DeleteEmprestimo
{
    public class DeleteEmprestimoCommand : IRequest<Unit>
    {
        public DeleteEmprestimoCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
