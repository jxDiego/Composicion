using lib_entidades;
namespace lib_repositorios.Interfaces
{
    public interface ICompuestosRepositorio
    {
        List<Compuestos> Listar();
        Compuestos Guardar(Compuestos entidad);
        Compuestos Modificar(Compuestos entidad);
        Compuestos Borrar(Compuestos entidad);
    }
}


