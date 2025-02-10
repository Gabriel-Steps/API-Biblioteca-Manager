using MediatR;
using SistemaBiblioteca.Core.Entities;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Commands.CreateUsuario
{
    public class CreateusuarioHandler : IRequestHandler<CreateUsuarioCommand, int>
    {
        private readonly IUsuarioRepository _context;
        public CreateusuarioHandler(IUsuarioRepository context) {
            _context = context;
        }
        public async Task<int> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = new Usuario(
                request.Nome,
                request.Email);
            await _context.CreateAsync(usuario);
            return usuario.Id;
        }
    }
}
