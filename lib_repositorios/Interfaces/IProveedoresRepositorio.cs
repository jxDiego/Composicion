using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface IProveedoresRepositorio
    {
        List<Proveedores> Listar();
        Proveedores Guardar(Proveedores entidad);
        Proveedores Modificar(Proveedores entidad);
        Proveedores Borrar(Proveedores entidad);
    }
}


