using Data.Entidades;

namespace LogicaNegocio.Repositorios
{
    public interface IMaestroRepositorio : IRepository<Maestro>
    {
        Maestro BuscarMaestroPorId(int maestroId);
    }
}
