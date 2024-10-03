using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class CompuestosPruebaUnitaria
    {
        private ICompuestosRepositorio? iRepositorio = null;
        private Compuestos? entidad = null;

        public CompuestosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = @"server=DESKTOP-V8TPOSL\DEV;database=DB_COMPOSICION;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new CompuestosRepositorio(conexion);
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
            entidad = new Compuestos()
            {
                Cod_compuesto = 1001,
                Nombre_composicion = "Ensalada César"
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);  // Verifica que se ha guardado correctamente y tiene un ID asignado
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);  // Verifica que hay al menos un compuesto en la lista
        }

        private void Modificar()
        {
            entidad!.Nombre_composicion = "Ensalada César Modificada";  // Modifica el nombre de la composición
            entidad = iRepositorio!.Modificar(entidad!);
            Assert.IsTrue(entidad!.Nombre_composicion == "Ensalada César Modificada");  // Verifica que el nombre se ha modificado correctamente
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            Assert.IsTrue(entidad!.Id != 0);  // Verifica que la entidad aún existe pero está marcada como borrada
        }
    }
}
