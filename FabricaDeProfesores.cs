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
	public class FabricaDeProfesores : FabricasdeComparables
	{
		public override IComparable CrearAleatorio(int opcion)
		{
			string nombre=GeneradorDatosAleatorios.StringAleatorio(6);
			int dni = GeneradorDatosAleatorios.NumerosAleatorio(9999999);
			int antiguedad = GeneradorDatosAleatorios.NumerosAleatorio(30);
			
			return	new Profesor(nombre , dni, antiguedad);
		}
		
		public override IComparable CrearPorTeclado(int opcion)
			
		{
			Cosole.WriteLine("Ingese nombre del Profesor");
			string nombre = LectorDeDatos.StringPorTeclado();
			
			Cosole.WriteLine("Ingese nombre del Profesor");
			int dni = LectorDeDatos.StringPorTeclado();
			
			Cosole.WriteLine("Ingese nombre del Profesor");
			int antiguedad = LectorDeDatos.StringPorTeclado();
			
			return new Profesor(nombre,dni,antiguedad);
			
		}
	}
}
