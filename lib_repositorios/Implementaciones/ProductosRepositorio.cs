using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class ProductosRepositorio : IProductosRepositorio
    {
        private Conexion? conexion = null;

        public ProductosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Productos> Listar()
        {
            return conexion!.Listar<Productos>();
        }

        public Productos Guardar(Productos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Productos Modificar(Productos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Productos Borrar(Productos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}