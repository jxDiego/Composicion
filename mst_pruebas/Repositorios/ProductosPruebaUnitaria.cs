using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class ProductosPruebaUnitaria
    {
        private IProductosRepositorio? iRepositorio = null;
        private Productos? entidad = null;

        public ProductosPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = @"server=DESKTOP-V8TPOSL\DEV;database=DB_COMPOSICION;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new ProductosRepositorio(conexion);
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
            entidad = new Productos()
            {
                Tipo_producto = 1,  // Supongamos que el tipo ya existe en la tabla Tipos_Productos
                Cod_producto = 101,
                Nombre_producto = "Manzana",
                Estado_producto = "Nuevo"
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);  // Verifica que se ha guardado correctamente y tiene un ID asignado
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);  // Verifica que hay al menos un producto en la lista
        }

        private void Modificar()
        {
            entidad!.Estado_producto = "Viejo";  // Cambia el estado del producto
            entidad = iRepositorio!.Modificar(entidad!);
            Assert.IsTrue(entidad!.Estado_producto == "Viejo");  // Verifica que el estado se ha modificado
        }

        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            Assert.IsTrue(entidad!.Id != 0);  // Verifica que la entidad aún existe pero está marcada como borrada
        }
    }
}
