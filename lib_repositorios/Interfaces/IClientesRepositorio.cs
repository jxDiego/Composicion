using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface IClientesRepositorio
    {
        List<Clientes> Listar();
        Clientes Guardar(Clientes entidad);
        Clientes Modificar(Clientes entidad);
        Clientes Borrar(Clientes entidad);
    }
}


