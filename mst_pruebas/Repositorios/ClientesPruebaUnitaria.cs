using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class ClientesPruebaUnitaria
    {
        private IClientesRepositorio? iRepositorio = null;
        private Clientes? entidad = null;

        public ClientesPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = @"server=DESKTOP-V8TPOSL\DEV;database=DB_COMPOSICION;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new ClientesRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Guardar();
            Listar();
            Modificar();
            Borrar();
        }

        private void Guardar()
        {
            entidad = new Clientes()
            {
                Cedula = "123456789",
                Nombre = "Juan Pérez",
                Contacto = 987654321,
                Direccion = "Calle Falsa 123"
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);  // Verifica que se ha guardado correctamente
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);  // Verifica que hay al menos un cliente en la lista
        }

        private void Modificar()
        {
            entidad!.Nombre = "Juan Pérez Modificado";
            entidad = iRepositorio!.Modificar(entidad!);
            Assert.IsTrue(entidad!.Nombre == "Juan Pérez Modificado");  // Verifica que el nombre se ha modificado
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            Assert.IsTrue(entidad!.Id != 0);  // Verifica que la entidad aún existe pero está marcada como borrada
        }
    }
}


//conexion.StringConnection = @"server=DESKTOP-V8TPOSL\DEV;database=BD_COMPOSICION;Integrated Security=True;TrustServerCertificate=true;";