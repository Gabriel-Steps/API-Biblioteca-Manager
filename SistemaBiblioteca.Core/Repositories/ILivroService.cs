using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Core.Repositories
{
    public interface ILivroService
    {
        bool LivroExiste(int idLivro);
        bool LivroDisponivel(int idLivro);
    }
}
