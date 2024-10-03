using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class Tipos_productosRepositorio : ITipos_productosRepositorio
    {
        private Conexion? conexion = null;

        public Tipos_productosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Tipos_productos> Listar()
        {
            return conexion!.Listar<Tipos_productos>();
        }

        public Tipos_productos Guardar(Tipos_productos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos_productos Modificar(Tipos_productos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos_productos Borrar(Tipos_productos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}