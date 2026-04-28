/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 18/4/2026
 * Hora: 16:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of IComparable.
	/// </summary>
	public interface IComparable
	{
		bool SosMayorQue(IComparable otro);
		bool SosMenorQue(IComparable otro);
		bool SosIgualQue(IComparable otro);
	}
}
