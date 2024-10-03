using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Ordenes
    {
        [Key] public int Id { get; set; }
        public int Cliente { get; set; }
        public int Compuesto { get; set; }
        public DateTime Fecha_pedido { get; set; }
        public string? Estado_orden { get; set; }
        public decimal Total_pagar { get; set; }

        [NotMapped] public Clientes? _Cliente { get; set; }
        [NotMapped] public Compuestos? _Compuesto { get; set; }
    }
}
