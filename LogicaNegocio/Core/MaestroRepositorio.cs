using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Entidades;
using LogicaNegocio.Repositorios;

namespace LogicaNegocio.Core
{
    public class MaestroRepositorio : Repositorio<Maestro>, IMaestroRepositorio
    {
        private readonly ApplicationDbContext _context;
        public MaestroRepositorio(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Maestro BuscarMaestroPorId(int maestroId)
        {
            return _context.Maestros.Where(x=>x.Id == maestroId)
                .Include(x=>x.Detalles).FirstOrDefault();
        }
    }
}
