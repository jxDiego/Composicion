using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface IProductosRepositorio
    {
        List<Productos> Listar();
        Productos Guardar(Productos entidad);
        Productos Modificar(Productos entidad);
        Productos Borrar(Productos entidad);
    }
}


