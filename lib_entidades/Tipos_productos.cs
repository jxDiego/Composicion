using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Tipos_productos
    {
        [Key] public int Id { get; set; }
        public int Cod_tipo { get; set; }
        public string? Nom_tipo { get; set; }
    }
}
