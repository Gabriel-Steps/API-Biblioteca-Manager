using MediatR;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.DeleteLivro
{
    public class DeleteLivroHandler : IRequestHandler<DeleteLivroCommand, Unit>
    {
        private readonly ILivroRepository _context;
        public DeleteLivroHandler(ILivroRepository context) {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteLivroCommand request, CancellationToken cancellationToken)
        {
            await _context.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}
