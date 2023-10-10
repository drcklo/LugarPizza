namespace LugarPizza.Models
{
    public class CarritoDeCompra
    {
        public Clientes Clientes { get; set; } = new Clientes();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool Pagado { get; set; }
    }
}
