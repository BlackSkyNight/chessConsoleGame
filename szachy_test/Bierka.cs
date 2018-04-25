using System;
using System.Collections.Generic;

namespace szachy_test
{
	public abstract class Bierka
	{
		protected bool kolor;
		protected int x;
		protected int y;

		public bool Kolor
		{
			get { return kolor;}
		}

		public Bierka (int x, int y, bool kolor)
		{
			this.x = x;
			this.y = y;
            this.kolor = kolor; // kolor gracza
			//Console.WriteLine ("konstruktor abstrakcyjny bierka x: "  + this.x + " y: " + this.y + " kolor: " + this.kolor);
		}

		//public abstract bool WykonajRuch (int x, int y);
		public abstract bool WykonajRuch (int x, int y, Pole pole);

		public virtual void Rysuj ()
		{
			if (this.kolor == false)
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
			}
		}
	}
}