﻿using LugarPizza.Models;

namespace LugarPizza.DAL
{
    public class Menu
    {
        public List<Pizzas> ListaDePizzas { get; set; }
        = new List<Pizzas>();
        public void AgregarPizza(Pizzas pizza)
        => ListaDePizzas.Add(pizza);
        public Pizzas? GetPizza(int id)
        => ListaDePizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
