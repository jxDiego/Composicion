using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private Conexion? conexion = null;

        public ClientesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Clientes> Listar()
        {
            return conexion!.Listar<Clientes>();
        }

        public Clientes Guardar(Clientes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Clientes Modificar(Clientes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Clientes Borrar(Clientes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}