using System;

namespace szachy_test
{
    public class Szachownica
    {
		private Pole [,] szachownica = new Pole[8, 8];

        public Szachownica()
        {
			for (int i = 1; i <= 8; i++) 
			{
				for (int j = 1; j <= 8; j++) 
				{
					this.szachownica [i - 1, j - 1] = new Pole (i, j);
                    Console.WriteLine(" szachownica [" + (i - 1) + ", " + (j - 1) + "]  X: " + szachownica[i - 1, j - 1].X + " Y: " + szachownica[i - 1, j - 1].Y);
				}
			}
        }

        public void RozstawSzachy(Gracz gracz)
        {
			if (gracz.Kolor == false) 
			{
				// pionki
				for (int i = 0; i < 8; i++) 
				{
					szachownica[1, i].Bierka = new Pionek(i + 1, 2, gracz.Kolor);
					szachownica [1, i].Zajete = true;
				}

				szachownica[0, 0].Bierka = new Wieza(1, 1, false);
				szachownica[0, 0].Zajete = true;
				szachownica[0, 7].Bierka = new Wieza(8, 1, false);
				szachownica[0, 7].Zajete = true;

				szachownica[0, 1].Bierka = new Skoczek(2, 1, false);
				szachownica[0, 1].Zajete = true;
				szachownica[0, 6].Bierka = new Skoczek(7, 1, false);
				szachownica[0, 6].Zajete = true;

				szachownica[0, 2].Bierka = new Goniec(3, 1, false);
				szachownica[0, 2].Zajete = true;
				szachownica[0, 5].Bierka = new Goniec(6, 1, false);
				szachownica[0, 5].Zajete = true;
			
				szachownica[0, 3].Bierka = new Krolowa(4, 1, false);
				szachownica[0, 3].Zajete = true;
				szachownica[0, 4].Bierka = new Krol(5, 1, false);
				szachownica[0, 4].Zajete = true;

			} 
			else if (gracz.Kolor == true)
			{
				// pionki
				for (int i = 0; i < 8; i++) 
				{
					szachownica[6, i].Bierka = new Pionek(i + 1, 7, gracz.Kolor);
					szachownica [6, i].Zajete = true;
				}

				szachownica[7, 0].Bierka = new Wieza(1, 8, true);
				szachownica[7, 0].Zajete = true;
				szachownica[7, 7].Bierka = new Wieza(8, 8, true);
				szachownica[7, 7].Zajete = true;

				szachownica[7, 1].Bierka = new Skoczek(2, 8, true);
				szachownica[7, 1].Zajete = true;
				szachownica[7, 6].Bierka = new Skoczek(7, 8, true);
				szachownica[7, 6].Zajete = true;
	
				szachownica[7, 2].Bierka = new Goniec(3, 8, true);
				szachownica[7, 2].Zajete = true;
				szachownica[7, 5].Bierka = new Goniec(6, 8, true);
				szachownica[7, 5].Zajete = true;

				szachownica[7, 3].Bierka = new Krolowa(4, 8, true);
				szachownica[7, 3].Zajete = true;
				szachownica[7, 4].Bierka = new Krol(5, 8, true);
				szachownica[7, 4].Zajete = true;
			}
            
        }

        public void RysujSzachownice()
		{
			Console.Clear ();
			string pom = "12345678";
			Console.WriteLine ("     Czarne\n\n");

			Console.WriteLine("   12345678 \n");

			for (int i = 7; i >= 0; i--)
			{
				Console.Write (pom [i] + "  ");
				for (int j = 0; j < 8; j++) 
				{
					if (szachownica [i, j].Zajete == true) 
					{
						if (szachownica [i, j].PoleKolor == ConsoleColor.Black) 
						{
							Console.BackgroundColor = szachownica [i, j].PoleKolor;
							szachownica [i, j].Bierka.Rysuj ();
							Console.ResetColor ();
						} 
						else 
						{
							Console.ResetColor ();
                            Console.BackgroundColor = ConsoleColor.White;
                            szachownica [i, j].Bierka.Rysuj ();
							Console.ResetColor ();
						}
					} 
					else 
					{
						if (szachownica [i, j].PoleKolor == ConsoleColor.Black) 
						{
							Console.BackgroundColor = szachownica [i, j].PoleKolor;
							Console.Write (" ");
							Console.ResetColor ();
						} 
						else 
						{
                            Console.ResetColor ();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write (" ");
							Console.ResetColor ();
						}
					}
				}
				Console.Write ("  " + pom [i]);
				Console.Write ("\n");
			}
			Console.WriteLine("\n   12345678");
			Console.WriteLine ("\n\n     Biale");
        }

		private void WczytajDana(ref int liczba,  string komunikat, int dolnyZakres, int gornyZakres)
		{
			Console.WriteLine (komunikat);
			bool result = int.TryParse (Console.ReadLine (), out liczba);

			if (result == true)
			{
				if (liczba >= dolnyZakres && liczba <= gornyZakres)
				{
					result = true;	
				}
				else
				{
					result = false;
				}
			}

			while (!result)
			{
				RysujSzachownice ();
				Console.WriteLine (komunikat);
				result = int.TryParse (Console.ReadLine (), out liczba);

				if (result == true)
				{
					if (liczba >= dolnyZakres && liczba <= gornyZakres)
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
		}


		private void ZamienKoordynatyNaWektor(int x_zrodlo, int y_zrodlo, int x_cel, int y_cel, ref int x_wektor, ref int y_wektor)
		{
			x_wektor = x_cel - x_zrodlo;
			y_wektor = y_cel - y_zrodlo;
		}
			
		private bool SprawdzDroge(int x_zrodla, int y_zrodla, int x_wektor, int y_wektor)
		{
            if (x_wektor > 1 && y_wektor == 0)
            {
                for (int i = x_zrodla; i < x_zrodla + x_wektor; i++)
                {
                    Console.WriteLine("szachownica[" + (i - 1) + ", " + (y_zrodla - 1) + "]  X: " + szachownica[i - 1, y_zrodla - 1].X + " Y: " + szachownica[i - 1, y_zrodla - 1].Y);
                    if (szachownica[i - 1, y_zrodla - 1].Zajete == true)
                    {
                        Console.WriteLine("zajete");
                    }
                }
                return true;
            }
            else if (x_wektor < -1 && y_wektor == 0)
            {
                for (int i = x_zrodla - 2; i > x_zrodla - x_wektor; i--)
                {
                    Console.WriteLine("szachownica[" + (i - 1) + ", " + (y_zrodla - 1) + "]  X: " + szachownica[i - 1, y_zrodla - 1].X + " Y: " + szachownica[i - 1, y_zrodla - 1].Y);
                    if (szachownica[i - 1, y_zrodla - 1].Zajete == true)
                    {
                        Console.WriteLine("zajete");
                    }
                }
            }
            return true;
		}

		public bool WykonajRuch(Gracz gracz)
		{
            bool zakonczonoRuch = false;
            bool zbitoKrola = false;
			int x_zrodlo = new int();
			int x_cel = new int();
			int y_zrodlo = new int();
			int y_cel = new int();
			int x_wektor = new int ();
			int y_wektor = new int ();

            do
            {
                WczytajDana(ref x_zrodlo, " Podaj wspolrzedna X bierki: ", 1, 8);
                WczytajDana(ref y_zrodlo, " Podaj wspolrzedna Y bierki: ", 1, 8);
                WczytajDana(ref x_cel, " Podaj wspolrzedna X celu: ", 1, 8);
                WczytajDana(ref y_cel, " Podaj wspolrzedna Y celu: ", 1, 8);


                if (szachownica[y_zrodlo - 1, x_zrodlo - 1].Bierka != null)
                {
                    if (szachownica[y_zrodlo - 1, x_zrodlo - 1].Bierka.Kolor == gracz.Kolor)
                    {
                        ZamienKoordynatyNaWektor(x_zrodlo, y_zrodlo, x_cel, y_cel, ref x_wektor, ref y_wektor);
                         
                        bool test = true;
                        if (x_wektor > 1 || y_wektor > 1 || x_wektor < -1 || y_wektor < -1)
                        {
                            Console.WriteLine("sprzawdzanie drogi");
                             test = SprawdzDroge(x_zrodlo, y_zrodlo, x_wektor, y_wektor);
                        }


                        if (szachownica[y_zrodlo - 1, x_zrodlo - 1].Bierka.WykonajRuch(x_wektor, y_wektor, szachownica[y_cel - 1, x_cel - 1]) && test == true)
                        {
                            Console.WriteLine(" Wykonano ruch");

                            if (szachownica[y_cel - 1, x_cel - 1].Zajete == true)
                            {
                                if (szachownica[y_cel - 1, x_cel - 1].Bierka.GetType() == typeof(szachy_test.Krol))
                                {
                                    zbitoKrola = true;
                                }
                            }

                            szachownica[y_cel - 1, x_cel - 1].Bierka = szachownica[y_zrodlo - 1, x_zrodlo - 1].Bierka;
                            szachownica[y_cel - 1, x_cel - 1].Zajete = true;
                            szachownica[y_zrodlo - 1, x_zrodlo - 1].Bierka = null;
                            szachownica[y_zrodlo - 1, x_zrodlo - 1].Zajete = false;
                            zakonczonoRuch = true;
                        }
                        else
                        {
                            Console.WriteLine(" Nie mozna wykonac ruchu");
                            Console.WriteLine(" Nacisnij dowolny przycisk aby powtorzyc ruch...");
                            Console.ReadKey();
                            Console.Clear();
                            RysujSzachownice();
                        }
                    }
                    else
                    {
                        Console.WriteLine(" To nie sa Twoje bierki! ");
                        Console.WriteLine(" Nacisnij dowolny przycisk aby powtorzyc ruch...");
                        Console.ReadKey();
                        Console.Clear();
                        RysujSzachownice();
                    }
                }
            } while (zakonczonoRuch != true);
            return zbitoKrola;
		}
    }
}