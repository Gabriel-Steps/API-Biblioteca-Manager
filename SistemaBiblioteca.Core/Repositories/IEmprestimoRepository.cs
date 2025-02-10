using SistemaBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Core.Repositories
{
    public interface IEmprestimoRepository
    {
        Task Add(Emprestimo emprestimo);
        Task Delete(int id);
    }
}
