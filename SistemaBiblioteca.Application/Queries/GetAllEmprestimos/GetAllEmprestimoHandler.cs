using MediatR;
using SistemaBiblioteca.Application.ViewModels;
using SistemaBiblioteca.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetAllEmprestimos
{
    public class GetAllEmprestimoHandler : IRequestHandler<GetAllEmprestimoQuery, List<EmprestimoViewModel>>
    {
        private readonly IEmprestimoRepository _context;
        public GetAllEmprestimoHandler(IEmprestimoRepository context)
        {
            _context = context;
        }

        public async Task<List<EmprestimoViewModel>> Handle(GetAllEmprestimoQuery request, CancellationToken cancellationToken)
        {
            var emprestimos = await _context.GetAllAsync();
            var emprestimoViewModel = emprestimos
                .Select(e => new EmprestimoViewModel(
                    e.Id,
                    e.IdUsuario,
                    e.IdLivro,
                    e.DataDeEmprestimo,
                    e.DataDeDevolucao)).ToList();
            return emprestimoViewModel;
        }
    }
}
