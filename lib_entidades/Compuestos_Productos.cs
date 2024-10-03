using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Compuestos_Productos
    {
        [Key] public int Id { get; set; }
        public int Compuesto { get; set; }
        public int Producto { get; set; }
        public int Cantidad_producto_necesario { get; set; }

        [NotMapped] public Compuestos? _Compuesto { get; set; }
        [NotMapped] public Productos? _Producto { get; set; }
    }
}
