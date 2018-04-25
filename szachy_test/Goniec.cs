using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szachy_test
{
    public class Goniec: Bierka
    {
        public Goniec(int x, int y, bool kolor) : base(x, y, kolor)
        {
			
        }
			
        public override void Rysuj()
        {
			base.Rysuj ();
            Console.Write("G");
        }

		public override bool WykonajRuch(int x, int y, Pole pole)
        {
			if (Math.Abs(x) == Math.Abs(y) && x != 0 && y!= 0 && pole.Zajete == true)
			{
				if (pole.Bierka.Kolor != this.kolor)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else if (Math.Abs(x) == Math.Abs(y) && x != 0 && y!= 0 && pole.Zajete == false)
			{
				return true;
			}
			return false;
        }
    }
}
