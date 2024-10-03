using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface IOrdenesRepositorio
    {
        List<Ordenes> Listar();
        Ordenes Guardar(Ordenes entidad);
        Ordenes Modificar(Ordenes entidad);
        Ordenes Borrar(Ordenes entidad);
    }
}


