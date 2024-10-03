using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface IProveedores_ProductosRepositorio
    {
        List<Proveedores_Productos> Listar();
        Proveedores_Productos Guardar(Proveedores_Productos entidad);
        Proveedores_Productos Modificar(Proveedores_Productos entidad);
        Proveedores_Productos Borrar(Proveedores_Productos entidad);
    }
}


