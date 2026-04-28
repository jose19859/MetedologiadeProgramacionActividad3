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
	/// Description of FabricaNumeros.
	/// </summary>
	/// 
				// FACTORY METHOD
	public abstract class  FabricaNumeros :FabricadeComparables
	{
		public override IComparable CrearAleatorio(int opcion)
		{
			int valor = GeneradorDatosAleatorios.NumerosAleatorios(100);
				return new Numero(valor);
		}
		
		public override IComparable CrearPorTeclado(int opcion)  
		{
			int valor = LectorDeDatos.NumeroPorTeclado();
			return	new Numero(valor);
		}
	
	}

}
