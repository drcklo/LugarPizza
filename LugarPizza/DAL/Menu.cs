using LugarPizza.Models;

namespace LugarPizza.Menu
{
    public class Menu
    {
        public List<Pizzas> ListaDePizzas { get; set; }
        = new List<Pizzas>();
        public void Add(Pizzas pizza)
        => ListaDePizzas.Add(pizza);
        public Pizzas? GetPizza(int id)
        => ListaDePizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
