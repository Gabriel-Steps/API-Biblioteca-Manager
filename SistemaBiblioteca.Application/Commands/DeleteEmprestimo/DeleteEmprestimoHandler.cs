using MediatR;
using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.DeleteEmprestimo
{
    public class DeleteEmprestimoHandler : IRequestHandler<DeleteEmprestimoCommand, Unit>
    {
        private readonly IEmprestimoRepository _context;
        public DeleteEmprestimoHandler(IEmprestimoRepository context) 
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteEmprestimoCommand request, CancellationToken cancellationToken)
        {
            await _context.Delete(request.Id);
            return Unit.Value;
        }
    }
}
