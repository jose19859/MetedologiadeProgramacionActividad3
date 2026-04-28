/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 09:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of FabricasdeComparables.
	/// </summary>
	public abstract class FabricadeComparables
	{
		public abstract IComparable CrearAleatorio(int opcion);
		
		public abstract IComparable CrearPorTeclado(int opcion);
		
		
	}
}
