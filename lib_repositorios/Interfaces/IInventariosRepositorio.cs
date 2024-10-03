using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface IInventariosRepositorio
    {
        List<Inventarios> Listar();
        Inventarios Guardar(Inventarios entidad);
        Inventarios Modificar(Inventarios entidad);
        Inventarios Borrar(Inventarios entidad);
    }
}


