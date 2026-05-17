/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 10:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona,IComparable
	{
		public int Antiguedad {get;set;}
		
		public Profesor(string nombre,int dni, int antiguedad):base(nombre,dni)
		{
			this.dni = dni;
		}
		
		public void HablarAlaClase()
		{
			Console.WriteLine("habla de algun tema ");
		}
		public void EscribirEnElPizarron()
		{
			Console.WriteLine("escribiendo en el pizarron");
			
		}
		public bool SosMayorQue(IComparable c)
		{
			Profesor otroProfesor =(Profesor)otro;
			return this.Dni > otroProfesor.Dni;
		}
		public bool SosMenorQue(IComparable c)
		{
			Profesor otroProfesor =(Profesor)otro;
			return this.Dni < otroProfesor.Dni;
		}
		public bool SosIgualQue(IComparable c)
		{
			Profesor otroProfesor =(Profesor)otro;
			return this.Dni == otroProfesor.Dni;
		}
	}
}
