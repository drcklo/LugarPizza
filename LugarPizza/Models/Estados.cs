using LugarPizza.DAL;

namespace LugarPizza.Models
{
    public class Estados
    {
        public Menu Menu { get; } = new Menu();
        public CarritoDeCompra Carrito { get; } = new CarritoDeCompra();
        public InterfazDeUsuario InterfazDeUsuario { get; set; } = new InterfazDeUsuario();
    }
}
