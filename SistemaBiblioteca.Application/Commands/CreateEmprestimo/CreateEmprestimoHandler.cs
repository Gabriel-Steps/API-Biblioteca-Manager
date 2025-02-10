using MediatR;
using SistemaBiblioteca.Core.Entities;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.CreateEmprestimo
{
    public class CreateEmprestimoHandler : IRequestHandler<CreateEmprestimoCommand, int>
    {
        private readonly IEmprestimoRepository _context;
        private readonly BibliotecaSistemaContext _contextDb;
        public CreateEmprestimoHandler(IEmprestimoRepository context, BibliotecaSistemaContext contextDb)
        {
            _context = context;
            _contextDb = contextDb;
        }
        public async Task<int> Handle(CreateEmprestimoCommand request, CancellationToken cancellationToken)
        {
            var emprestimo = new Emprestimo(
                request.IdLivro,
                request.IdUsuario);
            await _context.Add(emprestimo);
            return emprestimo.Id;
        }
    }
}
