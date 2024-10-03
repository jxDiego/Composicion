using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class Proveedores_ProductosRepositorio : IProveedores_ProductosRepositorio
    {
        private Conexion? conexion = null;

        public Proveedores_ProductosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Proveedores_Productos> Listar()
        {
            return conexion!.Listar<Proveedores_Productos>();
        }

        public Proveedores_Productos Guardar(Proveedores_Productos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Proveedores_Productos Modificar(Proveedores_Productos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Proveedores_Productos Borrar(Proveedores_Productos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}