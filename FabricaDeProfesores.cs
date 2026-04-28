/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 17:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores : FabricadeComparables
	{
		public override IComparable CrearAleatorio(int opcion)
		{
			string nombre=GeneradorDatosAleatorios.StringAleatorio(6);
			int dni = GeneradorDatosAleatorios.NumerosAleatorios(9999999);
			int antiguedad = GeneradorDatosAleatorios.NumerosAleatorios(30);
			
			return	new Profesor(nombre , dni, antiguedad);
		}
		
		public override IComparable CrearPorTeclado(int opcion)
			
		{
			Console.WriteLine("Ingese nombre del Profesor");
			string nombre = LectorDeDatos.StringPorTeclado();
			
			Console.WriteLine("Ingese nombre del Profesor");
			int dni = LectorDeDatos.NumeroPorTeclado();
			
			Console.WriteLine("Ingese nombre del Profesor");
			int antiguedad = LectorDeDatos.NumeroPorTeclado();
			
			return new Profesor(nombre,dni,antiguedad);
			
		}
	}
}
