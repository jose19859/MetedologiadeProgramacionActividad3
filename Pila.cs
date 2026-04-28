/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 28/3/2026
 * Hora: 18:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace ejercicio
{
	// Pila NO es un Iterador, es un IColeccionable.
	public class Pila : IColeccionable, IComparable
	{
		private List<IComparable> elementos = new List<IComparable>();

		public void Agregar(IComparable c) { elementos.Add(c); }
		public int Cuantos() { return elementos.Count; }
		
		public IComparable Maximo() {
			
			return elementos[0]; }
		
		public IComparable Minimo() {
			
			return elementos[0]; }
		
		public bool Contiene(IComparable c) {
			return false; }
		
		// La Pila sabe crear su propio iterador
		public Iterador crearIterador()
		{
			return new IteradorParaPila(this);
		}

		public List<IComparable> getElementos() { return this.elementos; }

		// Métodos de IComparable
		public bool SosMayorQue(IComparable otro) {
			return true; }
		public bool SosMenorQue(IComparable otro) { 
			return true; }
		public bool SosIgualQue(IComparable otro) { 
			return true; }
	}
}

