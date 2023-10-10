namespace LugarPizza.Models
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; } = default!;
        public string Calle { get; set; } = default!;
        public string Ciudad { get; set; } = default!;
    }
}
