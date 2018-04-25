using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szachy_test
{
    public class Krolowa: Bierka
    {
        public Krolowa(int x, int y, bool kolor) : base(x, y, kolor)
        {
			
        }

        public override void Rysuj()
        {
			base.Rysuj ();
            Console.Write("k");
        }

		public override bool WykonajRuch(int x, int y, Pole pole)
        {
			Console.WriteLine (" x: " + x + " y: " + y + " kolor: " + this.kolor);
			if (x > 0 && y == 0) // prawo
			{
				if (pole.Zajete == false) 
				{
					return true;
				}
				else if (pole.Bierka.Kolor != this.Kolor) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
			else if (x <= -1 && y == 0) // lewo
			{
				if (pole.Zajete == false) 
				{
					return true;
				}
				else if (pole.Bierka.Kolor != this.Kolor) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
			else if (Math.Abs(x) == Math.Abs(y) && x != 0 && y!= 0) // prawo gora
			{
				if (pole.Zajete == false) 
				{
					return true;
				}
				else if (pole.Bierka.Kolor != this.Kolor) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
			else if (x == 0 && y > 1) // gora
			{
				if (pole.Zajete == false) 
				{
					return true;
				}
				else if (pole.Bierka.Kolor != this.Kolor) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
			else if (x == 0 && y <= -1) // dol
			{
				if (pole.Zajete == false) 
				{
					return true;
				}
				else if (pole.Bierka.Kolor != this.Kolor) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
			return false;
        }
    }
}
