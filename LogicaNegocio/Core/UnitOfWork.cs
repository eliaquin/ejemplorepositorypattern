using Data;
using LogicaNegocio.Repositorios;

namespace LogicaNegocio.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Maestros = new MaestroRepositorio(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IMaestroRepositorio Maestros { get; }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
