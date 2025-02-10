using MediatR;
using SistemaBiblioteca.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Application.Queries.GetAllLivros
{
    public class GetAllLivroQuery : IRequest<List<LivroViewModel>>
    {
    }
}
