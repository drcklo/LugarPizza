﻿namespace LugarPizza.Models
{
    public class Pizzas
    {
        public Pizzas(int id, string nombre, decimal precio,
        NivelesDePicante nivelesDePicante)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.NivelesDePicante = nivelesDePicante;
        }
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public NivelesDePicante NivelesDePicante { get; }
    }
}
