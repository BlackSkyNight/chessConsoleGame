using System;
using System.Collections.Generic;

namespace szachy_test
{
	class MainClass
	{
		public static void Main (string[] args)
		{

            Menu menuGlowne = new Menu();
            Menu menuOpcje = new Menu();
            List<string> opcje = new List<string>();
            bool koniecProgramu = false;
            bool sterowanie = false;
            bool przerwijMenu = false;
            string imieGracza1;
            string imieGracza2;
            int numerRundy = 1;

            menuGlowne.DodajElement("Graj");
            menuGlowne.DodajElement("Opcje");
            menuGlowne.DodajElement("Koniec");

            opcje.Add("Sterowanie - wspolrzedne");
            opcje.Add("Sterowanie - wybieranie");
            opcje.Add("Powrot");

            menuOpcje.DodajElement(opcje);

            do
            {
                switch (menuGlowne.ObslugujMenu())
                {
                    case 0:
                        przerwijMenu = true;
                        break;
                    case 1:
                        Console.Clear();
                        switch (menuOpcje.ObslugujMenu())
                        {
                            case 0:
                                sterowanie = false;
                                break;

                            case 1:
                                sterowanie = true;
                                break;

                            case 2:
                                break;
                        }
                        //Console.Clear();
                        break;
                    case 2:
                        przerwijMenu = true;
                        koniecProgramu = true;
                        break;
                }
                Console.Clear();
            } while (przerwijMenu != true);

            if (koniecProgramu == false)
            {
                Console.WriteLine(" Gracz nr 1 (bierki biale) -> podaj swoje imie");
                imieGracza1 = Console.ReadLine();

                Console.WriteLine(" Gracz nr 2 (bierki czarne) -> podaj swoje imie");
                imieGracza2 = Console.ReadLine();

                Console.Clear();

                Gracz gracz1 = new Gracz(imieGracza1, false);
                Gracz gracz2 = new Gracz(imieGracza2, true);

                Szachownica szachownica = new Szachownica();
                szachownica.RozstawSzachy(gracz2);
                szachownica.RozstawSzachy(gracz1);

                while (true)
                {
                    if (numerRundy % 2 != 0) // gracz 1
                    {
                        Console.WriteLine(" Runda nr: " + numerRundy + ". Ruch gracza: " + gracz1.Imie + " kolor bierek: bialy");
                        Console.WriteLine(" Nacisnij dowolny przycisk aby rozpoczac runde... ");
                        Console.ReadKey();

                        szachownica.RysujSzachownice();
                        if(szachownica.WykonajRuch(gracz1))
                        {
                            Console.WriteLine(" Wygral gracz: " + gracz1.Imie);
                            Console.WriteLine(" Nacisnij 2 razy enter aby zakonczyc gre... ");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else // gracz 2
                    {
                        Console.WriteLine(" Runda nr: " + numerRundy + ". Ruch gracza: " + gracz1.Imie + " kolor bierek: czarny");
                        Console.WriteLine(" Nacisnij dowolny przycisk aby rozpoczac runde... ");
                        Console.ReadKey();

                        szachownica.RysujSzachownice();
                        if (szachownica.WykonajRuch(gracz2))
                        {
                            Console.WriteLine(" Wygral gracz: " + gracz2.Imie);
                            Console.WriteLine(" Nacisnij 2 razy enter aby zakonczyc gre... ");
                            Console.ReadKey();
                            break;
                        }
                    }
                   

                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine(" Nacisnij 2 razy enter aby zakonczyc gre... ");
                        break;
                    }
                    numerRundy++;
                    Console.Clear();
                }

                Console.ReadLine();
            }
		}
	}
}
