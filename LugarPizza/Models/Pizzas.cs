namespace LugarPizza.Models
{
    public class Pizzas
    {
        public Pizzas(int id, string nombre, decimal precio,
        NivelesDePicante nivelDePicante)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.NivelesDePicante = nivelDePicante;
        }
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public NivelesDePicante NivelesDePicante { get; }
    }
}
