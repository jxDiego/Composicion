using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class ProveedoresRepositorio : IProveedoresRepositorio
    {
        private Conexion? conexion = null;

        public ProveedoresRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Proveedores> Listar()
        {
            return conexion!.Listar<Proveedores>();
        }

        public Proveedores Guardar(Proveedores entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Proveedores Modificar(Proveedores entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Proveedores Borrar(Proveedores entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}