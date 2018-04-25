using System;

namespace szachy_test
{
    public class Wieza : Bierka
    {
       public Wieza(int x, int y, bool kolor): base(x, y, kolor)
        {
            
        }

        public override void Rysuj()
        {
			base.Rysuj ();
            Console.Write("W");
        }

		public override bool WykonajRuch (int x, int y, Pole pole)
        {
			Console.WriteLine (" x: " + x + " y: " + y + " kolor: " + this.kolor);
			if (SprawdzRuch (x, y, pole) == true) 
			{
				return true;
			}
			return false;
        }

		private bool SprawdzRuch(int x, int y, Pole pole)
		{
			if (x > 0 && y == 0)
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
			else if (x < 0 && y == 0)
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
			else if (x == 0 && y > 0)
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
			else if (x == 0 && y < 0)
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
    }
}

