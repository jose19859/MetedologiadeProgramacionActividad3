/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 9/4/2026
 * Hora: 02:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace ejercicio
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class IteradorParaPila : Iterador
	{
		private Pila pila;
		private int posicion;
		
		public IteradorParaPila(Pila p)
		{
			this.pila=p;
			this.posicion =0;
		}

		
		public bool SosMayorQue(IComparable otro)
			
		{
			IteradorParaPila o = otro as IteradorParaPila;
			if (o != null)
			{
				return this.posicion > o.posicion;
			}
			throw new ArgumentException("El objeto no es un IteradorParaPila");
		}

		public bool SosMenorQue(IComparable otro)
		{
			IteradorParaPila o = otro as IteradorParaPila;
			if (o != null)
			{
				return this.posicion < o.posicion;
			}
			throw new ArgumentException("El objeto no es un IteradorParaPila");
		}

		public bool SosIgualQue(IComparable otro)
		{
			IteradorParaPila o = otro as IteradorParaPila;
			
			if (o != null)
			{
				return this.posicion == o.posicion;
			}
			throw new ArgumentException("El objeto no es un IteradorParaPila");
		}

		// 3. MÉTODOS DEL ITERADOR
		public void primero() 
		{
			posicion = 0;
		}
		public void siguiente()
		{
			posicion++;
		}
		public bool fin() 
		{ 
			return posicion >= pila.Cuantos();
		}
		public IComparable actual() 
		{
			return pila.getElementos()[posicion];
		}
	}
}