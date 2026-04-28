using System;

namespace ejercicio
{
    class Program
    {
        public static void Main(string[] args)
        {
            Profesor profe = new Profesor("jose", 123456, 4);
            Pila p = new Pila();
            
            // Usamos una sola fábrica para el llenado
            FabricadeComparables fabrica = new FabricaAlumnos();
            Llenar(p, fabrica, 2);

            //  Registro de alumnos como observadores,usamos el iterador de la Pila
            Iterador ite = p.crearIterador();
            ite.primero();
            while (!ite.fin())
            {
                // Se asegura de que el elemento sea un observador antes de agregarlo
                IObservador obs = ite.actual() as IObservador;
                if (obs != null)
                {
                    profe.agregarObservador(obs);
                }
                ite.siguiente();
            }

            // Dictado de clases (Ejercicio 13 y 14)
            dictadoDeClases(profe);

            // Colección adicional e informe
            IColeccionable miColeccion = new Pila();
            FabricadeComparables miFabrica = new FabricaAlumnos();
            Llenar(miColeccion, miFabrica, 1);
            Informar(miColeccion);

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey(true);
        }

        public static void dictadoDeClases(Profesor p)
        {
            for (int i = 0; i < 5; i++)
            {
                p.HablarAlaClase();
                p.EscribirEnElPizarron();
            }
        }

        public static void Llenar(IColeccionable coleccion, FabricadeComparables fabrica, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                coleccion.Agregar(fabrica.CrearAleatorio(opcion));
            }
        }

        public static void Informar(IColeccionable coleccion)
        {
            Console.WriteLine("Cantidad: " + coleccion.Cuantos());
            Console.WriteLine("Maximo: " + coleccion.Maximo());
            Console.WriteLine("Minimo: " + coleccion.Minimo());
        }
    }
}