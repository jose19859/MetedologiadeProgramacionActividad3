/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 09:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of GeneradorDatosAleatorios.
	/// </summary>
	public class GeneradorDatosAleatorios
		
	{
		private static Random random = new Random();
		
		public static int NumerosAleatorios(int max)
		{
			return random.Next(0, max +1);
			
		}
		public  static int stringAleatorio(int cant)
		{
			const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string resultado="";
			
			for (int i=0;i < cant; i++)
			{
				resultado +=caracteres[random.Next(caracteres.Length)];
				
			}
			return resultado;
		}
	}
}
