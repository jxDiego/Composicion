using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Compuestos
    {
        [Key] public int Id { get; set; }
        public int Cod_compuesto { get; set; }
        public string? Nombre_composicion { get; set; }
    }
}
