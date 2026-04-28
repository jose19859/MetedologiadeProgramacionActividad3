/*
 * Created by SharpDevelop.
 * User: jose
 * Date: 20/4/2026
 * Time: 15:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio
{
	/// <summary>
	/// Description of Interface4.
	/// </summary>
	public interface Iterador:IComparable
	{
		void primero();
		void siguiente();
		bool fin();
		IComparable actual();
	}
		
}