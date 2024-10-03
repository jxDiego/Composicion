using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Clientes
    {
        [Key] public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public int Contacto { get; set; }
        public string? Direccion { get; set; }
    }
}

