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
	/// Description of Numero.
	/// </summary>
	public class Numero:IComparable
	{
		public int Valor {get; set;}
		public Numero(int valor)
			
		{
			this.Valor =valor;
		}
			public bool SosMayorQue(IComparable otro)
		{
			Numero otroNumero =(Numero)otro;
			return this.Valor > otroNumero.Valor;
		}
		public bool SosMenorQue(IComparable otro)
		{
			Numero otroNumero =(Numero)otro;
			return this.Valor < otroNumero.Valor;
		}
		public bool SosIgualQue(IComparable otro)
		{
			Numero otroNumero =(Numero)otro;
			return this.Valor == otroNumero.Valor;
		}
		
	}
}
