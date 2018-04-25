using System;
using System.Collections.Generic;

namespace szachy_test
{
	public class Gracz
	{
		private string imie;
		private bool kolor;     

        public bool Kolor
		{
			get 
			{
				return kolor;
			}

		}

		public string Imie
		{
			get {return imie;}
		}

        public Gracz (string imie, bool kolor)
		{
			this.imie = imie;
			this.kolor = kolor;
		}

	}
}