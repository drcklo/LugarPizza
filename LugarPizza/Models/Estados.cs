using LugarPizza.DAL;

namespace LugarPizza.Models
{
    public class Estados
    {
        public Menu Menu { get; } = new Menu();
        public CarritoDeCompra Carrito { get; } = new CarritoDeCompra();
        public InterfazDeUsuario InterfazDeUsuario { get; set; } = new InterfazDeUsuario();

		public decimal PrecioTotal
        => Carrito.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
	}
}
