using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Proveedores
    {
        [Key] public int Id { get; set; }
        public string? Nombre_Proveedor { get; set; }
        public int Contacto { get; set; }
    }
}
