using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class Compuestos_ProductosRepositorio : ICompuestos_ProductosRepositorio
    {
        private Conexion? conexion = null;

        public Compuestos_ProductosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Compuestos_Productos> Listar()
        {
            return conexion!.Listar<Compuestos_Productos>();
        }

        public Compuestos_Productos Guardar(Compuestos_Productos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Compuestos_Productos Modificar(Compuestos_Productos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Compuestos_Productos Borrar(Compuestos_Productos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}