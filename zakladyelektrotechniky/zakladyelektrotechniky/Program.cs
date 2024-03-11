using System;
using System.Runtime.InteropServices;
using System.Threading;


namespace zakladyelektrotechniky
{
    internal class Program
    { //Není můj kód od tuď
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_MAXIMIZE = 3;
        //potuď
        static void hlavni()
        {

            Console.Clear();
            Console.Title = "Základy elektrotechniky";

            Console.WriteLine("Vítejte v aplikaci pro elektrotechnické výpočty.");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Všechny hodnoty pište v celých číslech");
            Console.ResetColor();
            Console.WriteLine("Napište číslo jedné z následujících možností: \n1.Rezistory \n2.Výkon \n3.Napětí \n4.Proud \n5.Odpor\n6.Odejít  ");
            Console.Write("Vybraná možnost: ");
            int vstup = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(vstup);
            switch (vstup)
            {
                case 1:
                    Console.Clear();
                    Rezistory();
                    break;
                case 2:
                    Console.Clear();
                    vykon();
                    break;
                case 3:
                    Console.Clear();
                    Napeti();
                    break;
                case 4:
                    Console.Clear();
                    Proud();
                    break;
                case 5:
                    Console.Clear();
                    Odpor();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;



            }
        }
        static void Odpor()
        {
            Console.Clear();
            Console.WriteLine("Výpočet proudu R=U/I");
            Console.Write("Zadejte hodnotu napětí ve voltech: ");
            int napeti = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte hodnotu proudu v ampérech: ");
            int proud = Convert.ToInt32(Console.ReadLine());
            int odpor = napeti / proud;
            Console.WriteLine("Celkový odpor je " + proud + " ohmů");
            Console.WriteLine("Další možnosti\n1.Na hlavní stránku\n2.Zpět na výkon");
            Console.Write("Vybraná možnost");
            int moznosti = Convert.ToInt16(Console.ReadLine());
            switch (moznosti)
            {
                case 1:
                    hlavni();
                    break;
                case 2:
                    Odpor();
                    break;
            }
        }
        static void Proud()
        {
            Console.Clear();
            Console.WriteLine("Výpočet proudu I=U/R");
            Console.Write("Zadejte hodnotu napětí ve voltech: ");
            int napeti = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte hodnotu odporu v ohmech: ");
            int odpor = Convert.ToInt32(Console.ReadLine());
            int proud = napeti / odpor;
            Console.WriteLine("Celkový proud je " + proud + " ampérů");
            Console.WriteLine("Další možnosti\n1.Na hlavní stránku\n2.Zpět na výkon");
            Console.Write("Vybraná možnost");
            int moznosti = Convert.ToInt16(Console.ReadLine());
            switch (moznosti)
            {
                case 1:
                    hlavni();
                    break;
                case 2:
                    Proud();
                    break;
            }

        }
        static void Napeti()
        {
            Console.Clear();
            Console.WriteLine("Výpočet napětí U=I*R");
            Console.Write("Zadejte proud v ampérech: ");
            int proud = Convert.ToInt16(Console.ReadLine());
            Console.Write("Zadejte odpor v ohmech: ");
            int odpor = Convert.ToInt16(Console.ReadLine());
            int napeti = proud * odpor;
            Console.WriteLine("Napětí je " + napeti + " voltů");
            Console.WriteLine("Další možnosti\n1.Na hlavní stránku\n2.Zpět na výkon");
            Console.Write("Vybraná možnost");
            int moznosti = Convert.ToInt16(Console.ReadLine());
            switch (moznosti)
            {
                case 1:
                    hlavni();
                    break;
                case 2:
                    Napeti();
                    break;
            }
        }
        static void vykon()
        {
            Console.Clear();
            Console.WriteLine("Výpočet el. výkonu\n1.P=U*I\n2.P=(U^2)/R\n3.P=(I^2)/R");
            Console.Write("Vybraná možnost: ");
            int vstup = Convert.ToInt16(Console.ReadLine());
            int napeti = 0;
            int proud = 0;
            int odpor = 0;
            int vykon1 = 0;
            switch (vstup)
            {
                case 1:
                    Console.Write("Zadejte napětí ve voltech: ");
                    napeti = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Zadejte proud v ampérech: ");
                    proud = Convert.ToInt16(Console.ReadLine());
                    vykon1 = napeti * proud;
                    Console.WriteLine("Výkon je " + vykon1 + " Watů");
                    break;
                case 2:
                    Console.Write("Zadejte napětí ve voltech: ");
                    napeti = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Zadejte odpor v ohmech: ");
                    odpor = Convert.ToInt16(Console.ReadLine());
                    vykon1 = (napeti * napeti) / odpor;
                    Console.WriteLine("Výkon je " + vykon1 + " Watů");
                    break;
                case 3:
                    Console.Write("Zadejte proud v ampérech: ");
                    proud = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Zadejte odpor v ohmech: ");
                    odpor = Convert.ToInt16(Console.ReadLine());
                    vykon1 = (proud * proud) / odpor;
                    Console.WriteLine("Výkon je " + vykon1 + " Watů");
                    break;
            }
            Console.WriteLine("Další možnosti\n1.Na hlavní stránku\n2.Zpět na výkon");
            Console.Write("Vybraná možnost");
            int moznosti = Convert.ToInt16(Console.ReadLine());
            switch (moznosti)
            {
                case 1:
                    hlavni();
                    break;
                case 2:
                    vykon();
                    break;
            }
        }

        static void Rezistory()
        {
            Console.Clear();

            Console.WriteLine("Výpočet rezistorů.\n Jelikož tato aplikace je pouze pro základní výpočty, budeme počítat s maximálně 5 rezistory. ");
            Console.WriteLine("1.Sériově\n2.Paralelně");
            Console.Write("Vybraná možnost: ");
            int inRezistory = Convert.ToInt32(Console.ReadLine());
            switch (inRezistory)
            {
                case 1:
                    int[] poleRezistor = { 0, 0, 0, 0, 0 };
                    Console.WriteLine("Zadejte hodnotu odporu v ohmech, pokud tam není, zapište 0 ");
                    for (int i = 0; i < poleRezistor.Length; i++)
                    {

                        Console.Write("Zadejte hodnotu " + (i + 1) + ". rezistoru ");
                        int poleVstup = poleRezistor[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int hodnotaS = poleRezistor.Sum();
                    Console.WriteLine("Celkový odpor paralelně zapojených odporů je: " + hodnotaS + " ohmů");
                    break;
                //nebyl jsem schopnej to vymyslet, tak mi stím AI pomohla od tuď
                case 2:
                    double[] odpory = new double[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Zadejte hodnotu odporu č." + (i + 1) + " (nebo 0, pokud tam není žádný odpor): ");
                        odpory[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    double sumaReciprok = 0.0;
                    foreach (double hodnota in odpory)
                    {
                        if (hodnota != 0) sumaReciprok += 1.0 / hodnota;
                    }
                    double celkovyOdpor = 1.0 / sumaReciprok;
                    Console.WriteLine("Celkový odpor paralelně zapojených odporů je: " + celkovyOdpor + " ohmů");
                    //až sem
                    break;

            }
            Console.WriteLine("Další možnosti\n1.Na hlavní stránku\n2.Zpět na rezistory");
            Console.Write("Vybraná možnost");
            int moznosti = Convert.ToInt16(Console.ReadLine());
            switch (moznosti)
            {
                case 1:
                    hlavni();
                    break;
                case 2:
                    Rezistory();
                    break;
            }

        }

        static void Main(string[] args)
        {
            IntPtr handle = GetConsoleWindow();
            if (handle != IntPtr.Zero)
            {
                ShowWindow(handle, SW_MAXIMIZE);
            }
            try
            {
                hlavni();

            }
            catch (FormatException)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nastala chyba. Zpracovávání, může trvat několik minut.");
                Thread.Sleep(6000);
                Console.WriteLine("Chyba nalezena");
                Thread.Sleep(2000);
                Console.WriteLine("Chyba je samozřejmě v tobě, když jsi se pokusil zadat písmeno nebo znak tam, kde má být číslo, blbče.\nChceš se vrátit zpátky a zkusit to znovu?");
                string anoNe = Console.ReadLine();
                if (anoNe == "ano" || anoNe == "Ano" || anoNe == "aNo" || anoNe == "anO" || anoNe == "ANo" || anoNe == "AnO" || anoNe == "aNO" || anoNe == "ANO")
                {

                    Console.WriteLine("Dobrá tedy, budeš vrácen do hlavního menu");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    hlavni();
                }
                else if (anoNe == "ne" || anoNe == "NE" || anoNe == "nE" || anoNe == "Ne")
                {
                    Console.WriteLine("Dobrá tedy, aplikace bude zavřena");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }










            Console.Beep();
            Console.ReadKey();
        }
    }
}
