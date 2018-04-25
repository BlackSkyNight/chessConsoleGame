using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szachy_test
{
    public class Skoczek: Bierka
    {
        public Skoczek(int x, int y, bool kolor) : base(x, y, kolor)
        {
			//Console.WriteLine ("konstruktor skoczek x: " + this.x + " y: " + this.y + " kolor: " + this.kolor);
        }

		private bool SprawdzRuch(int x, int y, Pole pole)
		{
			if (x == 2 && y == 1) 
			{
				if (pole.Zajete == false) 
				{
					return true;
				} 
				else if (pole.Zajete == true && pole.Bierka.Kolor != this.kolor) 
				{
					return true;
				}
			}
			else if (x == 2 && y == -1)
			{
				if (pole.Zajete == false) 
				{
					return true;
				} 
				else if (pole.Zajete == true && pole.Bierka.Kolor != this.kolor) 
				{
					return true;
				}
			}
			else if (x == -2 && y == 1)
			{
				if (pole.Zajete == false) 
				{
					return true;
				} 
				else if (pole.Zajete == true && pole.Bierka.Kolor != this.kolor) 
				{
					return true;
				}
			}
			else if (x == -2 && y == -1)
			{
				if (pole.Zajete == false) 
				{
					return true;
				} 
				else if (pole.Zajete == true && pole.Bierka.Kolor != this.kolor) 
				{
					return true;
				}
			}
			else if (x == 1 && y == 2)
			{
				if (pole.Zajete == false) 
				{
					return true;
				} 
				else if (pole.Zajete == true && pole.Bierka.Kolor != this.kolor) 
				{
					return true;
				}
			}
			else if (x == 1 && y == -2)
			{
				return true;
			}
			else if (x == -1 && y == -2)
			{
				if (pole.Zajete == false) 
				{
					return true;
				} 
				else if (pole.Zajete == true && pole.Bierka.Kolor != this.kolor) 
				{
					return true;
				}
			}
			else if (x == -1 && y == 2)
			{
				if (pole.Zajete == false) 
				{
					return true;
				} 
				else if (pole.Zajete == true && pole.Bierka.Kolor != this.kolor) 
				{
					return true;
				}
			}
			return false;
		}

        public override void Rysuj()
        {
			base.Rysuj ();
            Console.Write("S");
        }

        public override bool WykonajRuch(int x, int y, Pole pole)
        {

			Console.WriteLine (" x: " + x + " y: " + y + " kolor: " + this.kolor);
			if (SprawdzRuch (x, y, pole) == true) 
			{
				return true;
			}

			return false;
        }
    }
}
