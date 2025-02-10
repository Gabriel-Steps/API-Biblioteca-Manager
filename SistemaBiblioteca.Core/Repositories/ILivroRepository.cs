using SistemaBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Core.Repositories
{
    public interface ILivroRepository
    {
        Task<List<Livro>> GetAll();
        Livro GetById(int id);
        Task AddAsync(Livro livro);
        Task DeleteAsync(int id);
    }
}
