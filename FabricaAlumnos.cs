/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 09:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of FabricaAlumnos.
	/// </summary>
	public class FabricaAlumnos : FabricasdeComparables
	{
		public override IComparable CrearAleatorio(int opcion)
		{
			string nombre = GeneradorDatosAleatorios.StringAleatorio(5);
			int dni = GeneradorDatosAleatorios.NumerosAleatorio(9999999);
			return new Alumno(nombre,dni);
		}
		
		public override IComparable CrearPorTeclado(int opcion)
		{
			Console.WriteLine("ingrese nombre");
			string nombre = LectorDeDatos.StringPorTeclado();
			
			Console.WriteLine("ingrese DNI");
			int dni = LectorDeDatos.StringPorTeclado();
			
			return new Alumno(nombre,dni);
		}
	}
}
