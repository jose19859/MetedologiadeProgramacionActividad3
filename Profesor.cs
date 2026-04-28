using System;
using System.Collections.Generic;

namespace ejercicio
{
    public class Profesor : Persona, IComparable
    {
        public int Antiguedad { get; set; }
        private List<IObservador> observadores = new List<IObservador>();

        public Profesor(string nombre, int Dni, int antiguedad) : base(nombre, Dni)
        {
            this.Antiguedad = antiguedad;
        }

        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void HablarAlaClase()
        {
            Console.WriteLine("habla de algun tema ");
            foreach (var o in observadores)
            {
                Alumno a = o as Alumno;
                if (a != null) a.prestarAtencion();
            }
        }

        public void EscribirEnElPizarron()
        {
            Console.WriteLine("escribiendo en el pizarron");
            foreach (var o in observadores)
            {
                Alumno a = o as Alumno;
                if (a != null) a.distraerse();
            }
        }

        public override bool SosMayorQue(IComparable otro)
        {
            Profesor otroProfesor = (Profesor)otro;
            return this.Antiguedad > otroProfesor.Antiguedad;
        }

        public override bool SosMenorQue(IComparable otro)
        {
            Profesor otroProfesor = (Profesor)otro;
            return this.Antiguedad < otroProfesor.Antiguedad;
        }

        public override bool SosIgualQue(IComparable otro)
        {
            Profesor otroProfesor = (Profesor)otro;
           return this.Antiguedad == otroProfesor.Antiguedad;
        }
    } 
} 