using System.Text.Json;

namespace LugarPizza.Clients
{
	public static class ExtensionesDeDebug
	{
		private static JsonSerializerOptions opciones = new
	   JsonSerializerOptions
		{ WriteIndented = true };
		public static string ToJson(this object obj)
		=> JsonSerializer.Serialize(obj, opciones);
	}

}
