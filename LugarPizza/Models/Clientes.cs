﻿using System.ComponentModel.DataAnnotations;

namespace LugarPizza.Models
{
    public class Clientes
    {
       
        public int IdCliente { get; set; }
		[Required(ErrorMessage = "Por favor escriba un nombre")]
		public string Nombre { get; set; } = default!;
		[Required(ErrorMessage = "Por favor escriba una calle con su numero de casa")]
		public string Calle { get; set; } = default!;
		[Required(ErrorMessage = "Por favor escriba una ciudad")]
		public string Ciudad { get; set; } = default!;
    }
}
