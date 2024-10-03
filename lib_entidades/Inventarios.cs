using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Inventarios
    {
        [Key] public int Id { get; set; }
        public int Producto { get; set; }
        public int Cantidad_afectar { get; set; }
        public string? Accion_estado { get; set; }

        [NotMapped] public Productos? _Producto { get; set; }
    }
}
