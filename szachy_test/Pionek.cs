using System;
using System.Collections.Generic;

namespace szachy_test
{
	public class Pionek: Bierka
	{
		private bool pierwszyRuch;

		public Pionek (int x, int y, bool kolor): base(x, y, kolor)
		{
			pierwszyRuch = true;
		}
			

		public override bool WykonajRuch (int x, int y, Pole pole)
		{
			Console.WriteLine (" x: " + x + " y: " + y + " kolor: " + this.kolor + " pierwszy ruch : " + this.pierwszyRuch);
			if (SprawdzRuch (x, y, pole) == true) 
			{
				return true;
			}
			return false;
		}

		private bool SprawdzRuch(int x, int y, Pole pole)
		{
			if (pierwszyRuch == true) 
			{
				if (this.kolor == false) // jesli kolor bialy
				{  
					if (((y == 1 || y == 2) && x == 0) && pole.Zajete == false)
					{
						pierwszyRuch = false;
						return true;
					}
					else if ((y == 1 && x == 1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						pierwszyRuch = false;
						return true;
					}
					else if ((y == 1 && x == -1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						pierwszyRuch = false;
						return true;
					}
				} 
				else if (this.kolor == true) // jesli kolor jest czarny
				{ 
					if (((y == -1 || y == -2) && x == 0) && pole.Zajete == false)
					{
						pierwszyRuch = false;
						return true;
					}
					else if ((y == -1 && x == 1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						pierwszyRuch = false;
						return true;
					}
					else if ((y == -1 && x == -1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						pierwszyRuch = false;
						return true;
					}
				}
			}
			else
			{
				if (this.kolor == false) 
				{ 
					if ((y == 1 && x == 0) && pole.Zajete == false) 
					{
						return true;
					}
					else if ((y == 1 && x == 1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						return true;
					}
					else if ((y == 1 && x == -1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						return true;
					}
				}
				else if (this.kolor == true)
				{
					if ((y == -1 && x == 0) && pole.Zajete == false)
					{
						return true;
					}
					else if ((y == -1 && x == 1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						return true;
					}
					else if ((y == -1 && x == -1) && pole.Zajete == true && pole.Bierka.Kolor != this.kolor)
					{
						return true;
					}
				}
			}
			return false;
		}
			
		override public void Rysuj ()
		{
			base.Rysuj ();
			Console.Write ("P");
		}
	}
}

