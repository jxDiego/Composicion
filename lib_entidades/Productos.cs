using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Productos
    {
        [Key] public int Id { get; set; }
        public int Tipo_producto { get; set; }
        public int Cod_producto { get; set; }
        public string? Nombre_producto { get; set; }
        public string? Estado_producto { get; set; }

        [NotMapped] public Tipos_productos? _Tipo_producto { get; set; }
    }
}
