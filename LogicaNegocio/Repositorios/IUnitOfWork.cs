using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Repositorios
{
    public interface IUnitOfWork : IDisposable
    {
        IMaestroRepositorio Maestros { get; }
        int Save();
    }
}
