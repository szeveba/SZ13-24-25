namespace ConsoleApp
{
    internal class Program
    {
        static void VezérlésiSzerkezetekJegyzet()
        {
            // VEZÉRLÉSI SZERKEZETEK
            // 1. szekvencia
            // utasítások sorozata egymás után...
            // 2. elágazás
            if (true)
            {
                // ez hajtódik végre igaz esetén
            }

            if (false)
            {

            }
            else
            {
                // ez hajtódik végre hamis esetén
            }
            int i = 0;
            if (i == 0)
            {
                if (true)
                {

                }
            }
            else if (true)
            {

            }

            // speciális eset: értékvizsgálat
            if (i == 0)
            {
                Console.WriteLine(0);
            }
            else if (i == 1)
            {
                Console.WriteLine(1);
            }
            else if (i == 2)
            {
                Console.WriteLine(2);
            }
            else if (i == 3 || i == 4)
            {
                Console.WriteLine("3 vagy 4");
            }
            else
            {
                Console.WriteLine("minden más esetben");
            }

            // ezt ne így.. erre van a switch-case

            switch (i)
            {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                case 4:
                    Console.WriteLine("3 vagy 4");
                    break;
                default:
                    Console.WriteLine("minden más esetben");
                    break;
            }

            var tömb = new string[5];

            // 3. ciklus
            // előltetsztelős -> nem biztos hogy egyszer is végre akarjuk hajtani
            while (i == 0)
            {

            }
            // hátultesztelős
            do
            {

            } while (i == 0);

            // számláló -> ha valahányszor..
            for (int index = 0; index < 3; index++)
            {

            }

            // for while-al

            int index2 = 0;
            while (index2 < 3)
            {
                //... ciklusmag
                index2++;
            }

            // bejárás -> !!! a bejárás közben az éppen bejárt gyűjtemény elemszámát tilos módosítani !!!
            foreach (var item in tömb)
            {
                if (item == "") continue;
                if (item != "")
                {

                }
            }
            //foreach mit csinál?
            var enumerator = tömb.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                //...
            }

            // ciklus vezérlési utasításai
            // 1. break; => megszakítja a ciklus végrehajtását
            // 2. continue; => megszakítja az adott ciklus iterációját

            // indexelés...
            // sorszámozás jelentése: valamihez sorrendben számok hozzárendelése 1-től
            // indexelés ugyan ez csak a 0-hoz igazítva
        }
        static void VisualStudioHasználata()
        {
            /*
                 * F5 futtatás vagy futtatás folytatása debug módban
                 * Ctrl+F5 futtatás debug nélkül (nincsenek breakpointok!!)
                 * Ctrl+Shift+F5 újrafordítás és indítás
                 * F6 fordítás futtatás nélkül (build)
                 * F11 vezérlés léptetése a következő utasításra (függvényekbe is belép)
                 * F10 vezérlés léptetése a következő utasításra (függvény végrehajtása egy lépés)
                 * F9 breakpoint elhelyezése vagy törléseű
                 * 
                 * Ctrl+M+O függvények összezárása
                 * Ctrl+M+M adott szekció kinyitása vagy összecsukása
                 * Ctrl+K+D kód formázása
                 * Ctrl+- visszalépés a kurzor előbbi pozíciójába
                 * Ctrl+Q funkció keresés
                 * Ctrl+T kódban való keresés (navigációs szempontból)
                 * 
                 * Alt+Shift+fel vagy le nyíl: multiline editing
                 */
        }
        static void KeretRajzolás()
        {
            do
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.CursorVisible = false;

                //╔╗╚╝║═

                Console.Write('╔');
                for (int i = 1; i < Console.WindowWidth - 1; i++)
                {
                    Console.Write('═');
                }
                Console.Write('╗');
                for (int i = 1; i < Console.WindowHeight - 1; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write("║");
                }
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                Console.Write('╝');
                for (int i = Console.CursorLeft - 1; i > 0; i--)
                {
                    Console.SetCursorPosition(i, Console.WindowHeight - 1);
                    Console.Write('═');
                }
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write('╚');
                for (int i = Console.WindowHeight - 2; i > 0; i--)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("║");
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        static void KeretRajzolás2()
        {
            //║═
            do
            {
                Console.ResetColor();
                Console.Clear();
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 0);
                Console.Write('╔');
                Console.SetCursorPosition(Console.WindowWidth - 1, 0);
                Console.Write('╗');
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write('╚');
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                Console.Write('╝');
                Console.SetCursorPosition(1, 0);
                for (int i = 0; i < Console.WindowWidth - 2; i++)
                {
                    Console.Write('═');
                }
                Console.SetCursorPosition(1, Console.WindowHeight - 1);
                for (int i = 0; i < Console.WindowWidth - 2; i++)
                {
                    Console.Write('═');
                }
                for (int i = 1; i < Console.WindowHeight - 1; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write('║');
                }
                for (int i = 1; i < Console.WindowHeight - 1; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write('║');
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static void KeretRajzolás3()
        {
            //╔╗╚╝║═
            do
            {
                Console.Write("".PadRight(Console.WindowWidth * Console.WindowHeight * 1, ' '));
                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.CursorVisible = false;
                Console.Write("╔".PadRight(Console.WindowWidth - 1, '═') + "╗");
                for (int i = 0; i < Console.WindowHeight - 2; i++)
                {
                    Console.Write("║".PadRight(Console.WindowWidth - 1, ' ') + "║");
                }
                Console.Write("╚".PadRight(Console.WindowWidth - 1, '═') + "╝");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
        static void Main(string[] args)
        {
            //asd
            KeretRajzolás3();
            Console.ReadLine();
        }
    }
}
