/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 16:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno:IComparable
	{
		public string Nombre {get;set;}
		public int Dni {get;set;}
		
		public Alumno(string nombre,int Dni)
			
		{
			this.Nombre=nombre;
			this.Dni=Dni;
		}
		public bool SosMayorQue(IComparable otro)
		{
			Alumno otroAlumno =(Alumno)otro;
			return this.Dni > otroAlumno.Dni;
		}
		public bool SosMenorQue(IComparable otro)
		{
			Alumno otroAlumno =(Alumno)otro;
			return this.Dni < otroAlumno.Dni;
		}
		public bool SosIgualQue(IComparable otro)
		{
			Alumno otroAlumno =(Alumno)otro;
			return this.Dni == otroAlumno.Dni;
		}
		
	}
}
