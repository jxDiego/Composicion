using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface ICompuestos_ProductosRepositorio
    {
        List<Compuestos_Productos> Listar();
        Compuestos_Productos Guardar(Compuestos_Productos entidad);
        Compuestos_Productos Modificar(Compuestos_Productos entidad);
        Compuestos_Productos Borrar(Compuestos_Productos entidad);
    }
}


