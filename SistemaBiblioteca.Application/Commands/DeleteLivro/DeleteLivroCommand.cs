using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.DeleteLivro
{
    public class DeleteLivroCommand : IRequest<Unit>
    {
        public DeleteLivroCommand(int id) 
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
