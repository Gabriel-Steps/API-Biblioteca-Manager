using MediatR;
using SistemaBiblioteca.Application.ViewModels;
using SistemaBiblioteca.Core.Repositories;
using SistemaBiblioteca.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetUsuario
{
    public class GetUsuarioHandler : IRequestHandler<GetUsuarioQuery, UsuarioDetailsViewModel>
    {
        private readonly IUsuarioRepository _context;
        public GetUsuarioHandler(IUsuarioRepository context) 
        {
            _context = context;
        }
        public async Task<UsuarioDetailsViewModel> Handle(GetUsuarioQuery request, CancellationToken cancellationToken)
        {
            var user = _context.GetById(request.Id);
            if (user == null)
            {
                throw new Exception("Usuário não encontrado!");
            }
            var usuarioInfo = new UsuarioDetailsViewModel(user.Id, user.Nome, user.Email);
            return usuarioInfo;
        }
    }
}
