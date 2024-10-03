using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class OrdenesRepositorio : IOrdenesRepositorio
    {
        private Conexion? conexion = null;

        public OrdenesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Ordenes> Listar()
        {
            return conexion!.Listar<Ordenes>();
        }

        public Ordenes Guardar(Ordenes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Ordenes Modificar(Ordenes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Ordenes Borrar(Ordenes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}