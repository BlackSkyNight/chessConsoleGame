using System;
using System.Collections.Generic;

namespace szachy_test
{
	public class Menu
	{
        private int maksymalnaDlugosc = 0;
        private int aktualnyIndeks = 0;
        private int wybranyIndeks;
		private List<string> elementyMenu; 
		public List<string> ElementyMenu
		{
			get {return elementyMenu;}
		}

		public Menu ()
		{
			elementyMenu = new List<string> ();
		}

		public Menu(List <string> elementy)
		{
			foreach (var element in elementy) 
			{
				elementyMenu.Add (element);
			}
		}

        private void AktualizujSzerokoscMenu()
        {
            foreach (var element in elementyMenu)
            {
                if (maksymalnaDlugosc < element.Length)
                {
                    maksymalnaDlugosc = element.Length;
                }
            }
        }

		public void DodajElement(string element)
		{
			elementyMenu.Add (element);
		}

        public void DodajElement(List<String> elementy)
        {
            foreach (var element in elementy)
            {
                elementyMenu.Add(element);
            }
        }

        public int ObslugujMenu()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                RysujMenu();
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (aktualnyIndeks > 0)
                        {
                            aktualnyIndeks--;
                        }
                        else
                        {
                            aktualnyIndeks = elementyMenu.Count - 1;
                        }
                        RysujMenu();
                        break;

                    case ConsoleKey.DownArrow:
                        if (aktualnyIndeks < elementyMenu.Count - 1)
                        {
                            aktualnyIndeks++;
                        }
                        else
                        {
                            aktualnyIndeks = 0;
                        }
                        RysujMenu();
                        break;

                    case ConsoleKey.Enter:
                        wybranyIndeks = aktualnyIndeks;
                        return wybranyIndeks;
                }
                Console.Clear();

            } while (wybranyIndeks != elementyMenu.Count - 1);
            return wybranyIndeks;
        }

        private void RysujMenu()
        {
            for (int i = 0; i < elementyMenu.Count; i++)
            {
                Console.ResetColor();
                if (i == aktualnyIndeks)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }

                if (elementyMenu[i].Length < maksymalnaDlugosc)
                {
                    Console.WriteLine();
                    for (int j = 0; j < maksymalnaDlugosc / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(elementyMenu[i]);

                    for (int j = 0; j < maksymalnaDlugosc / 2; j++)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.WriteLine(elementyMenu[i]);
                }
            }
            Console.ResetColor();
        }
	}
}