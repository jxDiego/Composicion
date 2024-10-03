using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface ITipos_productosRepositorio
    {
        List<Tipos_productos> Listar();
        Tipos_productos Guardar(Tipos_productos entidad);
        Tipos_productos Modificar(Tipos_productos entidad);
        Tipos_productos Borrar(Tipos_productos entidad);
    }
}


