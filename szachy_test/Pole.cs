using System;

namespace szachy_test
{
	public class Pole
	{
		private int x;
		private int y;
		private bool zajete;
		private ConsoleColor poleKolor;

		public ConsoleColor PoleKolor 
		{
			get {return poleKolor; }
		}

		public bool Zajete {
			get {
				return zajete;
			}
			set {
				zajete = value;
			}
		}

		private Bierka bierka;

		public Bierka Bierka {
			get {
				return bierka;
			}
			set {
				bierka = value;
			}
		}

		public int X
		{
			get {return x; }
			set 
			{ 
				x = value;
			}
		}
		public int Y
		{
			get { return y;}
			set 
			{
				y = value;
			}
		}



        public Pole(int x, int y,  Bierka bierka)
		{
			this.x = x;
			this.y = y;
            this.Bierka = bierka;

			if ((x + y) % 2 == 0) {
				poleKolor = ConsoleColor.Black;
			} else {
				poleKolor = ConsoleColor.White;
			}
		}

        public Pole(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Bierka = null;

			if ((x + y) % 2 == 0) {
				poleKolor = ConsoleColor.Black;
			} else {
				poleKolor = ConsoleColor.White;
			}
        }
	}
}