/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 09:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public static class LectorDeDatos
	{
		
		public static int NumeroPorTeclado()
		{
			Console.WriteLine("ingrese un numero por teclado");
			string entrada = Console.ReadLine();
			return int.Parse(entrada);
		}
		public static string StringPorTeclado()
		{
			Console.WriteLine("ingrese un string por teclado");
			return Console.ReadLine();
			
		}
	}
}
