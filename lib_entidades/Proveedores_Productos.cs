using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Proveedores_Productos
    {
        [Key] public int Id { get; set; }
        public int Producto { get; set; }
        public int Proveedor { get; set; }
        public int Cantidad_producto { get; set; }
        public DateTime Fecha_entrega { get; set; }

        [NotMapped] public Productos? _Producto { get; set; }
        [NotMapped] public Proveedores? _Proveedor { get; set; }
    }
}
