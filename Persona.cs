/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 19/4/2026
 * Hora: 13:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	
	public class Persona:IComparable //se implementa la interface Comparable
	{
		public string Nombre;
		 public int  Dni;
		
		public Persona(string n,int d)
		{
			Nombre=n;
			Dni = d;
		}
		public string getNombre()
		{
			return Nombre;	
		}
		
		public int getDni()
		{
			return Dni;
		}
		

		
			public bool SosMayorQue(IComparable c)
			{ 
				return this.Dni>((persona)c).getDni();
			}
			
			public bool SosMenorQue(IComparable c)
			{ 
				return this.Dni<((persona)c).getDni();
			}
			
			public bool SosIgualQue(IComparable c)
			{ 
				return this.Dni==((persona)c).getDni();
			}
		}
	}


