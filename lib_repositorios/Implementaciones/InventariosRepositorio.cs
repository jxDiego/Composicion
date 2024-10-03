using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class InventariosRepositorio : IInventariosRepositorio
    {
        private Conexion? conexion = null;

        public InventariosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Inventarios> Listar()
        {
            return conexion!.Listar<Inventarios>();
        }

        public Inventarios Guardar(Inventarios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Inventarios Modificar(Inventarios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Inventarios Borrar(Inventarios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}