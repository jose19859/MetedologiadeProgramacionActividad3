/*
 * Created by SharpDevelop.
 * User: jose
 * Date: 19/4/2026
 * Time: 22:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of IColeccionable.
	/// </summary>
	public interface IColeccionable
    {
        void Agregar(IComparable c);
        int Cuantos();
        IComparable Maximo();
        IComparable Minimo();
        bool Contiene(IComparable c);
        Iterador crearIterador();
    }
}

