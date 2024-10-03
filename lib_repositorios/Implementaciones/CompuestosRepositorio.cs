using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class CompuestosRepositorio : ICompuestosRepositorio
    {
        private Conexion? conexion = null;

        public CompuestosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Compuestos> Listar()
        {
            return conexion!.Listar<Compuestos>();
        }

        public Compuestos Guardar(Compuestos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Compuestos Modificar(Compuestos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Compuestos Borrar(Compuestos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}