using System;

namespace ejercicio
{
    public class Alumno : IComparable, IObservador // implementa la interfece Icomparbe y Iobservador
    {
        public string Nombre {get;set;}
        public int Dni {get;set;}
        
        public Alumno(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        // --- Implementación IComparable ---
        public bool SosMayorQue(IComparable otro)
        {
            Alumno otroAlumno = (Alumno)otro;
            return this.Dni > otroAlumno.Dni;
        }
        public bool SosMenorQue(IComparable otro)
        {
            Alumno otroAlumno = (Alumno)otro;
            return this.Dni < otroAlumno.Dni;
        }
        public bool SosIgualQue(IComparable otro)
        {
            Alumno otroAlumno = (Alumno)otro;
            return this.Dni == otroAlumno.Dni;
        }

       
        public void Actualizar(IComparable objeto)
        {
            Profesor profe = objeto as Profesor;
            if (profe != null)
            {
                Console.WriteLine(this.Nombre + " recibió la actualización.");
                prestarAtencion(); 
            }
        }

        public void prestarAtencion() { Console.WriteLine(this.Nombre + ": Prestando atención"); }
        
        public void distraerse() {
            string[] frases = { "Mirando el celular", "Dibujando", "Tirando aviones" };
            Console.WriteLine(this.Nombre + ": " + frases[new Random().Next(frases.Length)]);
        }
        public override string ToString()
        {
        	return this.Nombre;
        }
    }
}