/*
 * Creado por SharpDevelop.
 * Usuario: jose
 * Fecha: 15/4/2026
 * Hora: 17:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ejercicio
{
	class Program
	{
		public static void Main(string[] args)
		{
		Profesor profe = new Profesor("jose", 123456,4);
		Pila p = new Pila();
		Llenar(p, 2);
		Iterador ite=p.crearIterador();
		ite.primero();
		
		while (!ite.fin())
		{
			profe.agregarObservador((IObservador)ite.actual());
			ite.Siguiente();
		}
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void Llenar(IComparable coparables, int opcion)
		{
			FabricaDeComparables fabrica;
			
			if (opcion == 1)
				fabrica = new FabricaNumeros();
			else
				fabrica = new FabricaAlumnos();
			
			
			for (int i=0; i<20;i++)
			{
				Comparable Comparable = fabrica.CrearAleatorio(opcion);
				coleccionable.Agregar(comparable);
			}
		}
		
		
	}
}// me quede en el ejercicio de observador... hay que verificar errores