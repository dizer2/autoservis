using System;
using System.Collections.Generic;


class Auto
{
    public string Vyrobce { get; set; }
    public string TypAuta { get; set; }
    public int RokVyroby { get; set; }
    public int NajeteKilometry { get; set; }
    public string Stav { get; set; }
}

class Program
{
    static List<Auto> autoservis = new List<Auto>();

    static void Main(string[] args)
    {
        bool runProgram = true;

        while (runProgram)
        {
            Console.WriteLine("Vítejte v autoservisu!");
            Console.WriteLine("1. Přidat nový automobil");
            Console.WriteLine("2. Opravit automobil");
            Console.WriteLine("3. Vypisovat informace o automobilech");
            Console.WriteLine("4. Smazat záznam automobilu");
            Console.WriteLine("5. Ukončit program");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PridatAutomobil();
                    break;
                case 2:
                    OpravitAutomobil();
                    break;
                case 3:
                    VypisInformaceOAutomobilech();
                    break;
                case 4:
                    SmazatZaznamAutomobilu();
                    break;
                case 5:
                    runProgram = false;
                    break;
                default:
                    Console.WriteLine("Neplatná volba, zkuste to znovu.");
                    break;
            }
        }
    }

    static void PridatAutomobil()
    {
        Auto auto = new Auto();

        Console.WriteLine("Zadejte výrobce:");
        auto.Vyrobce = Console.ReadLine();

        Console.WriteLine("Zadejte typ auta:");
        auto.TypAuta = Console.ReadLine();

        Console.WriteLine("Zadejte rok výroby:");
        auto.RokVyroby = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadejte najeté kilometry:");
        auto.NajeteKilometry = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadejte stav automobilu (nový, servis, opravený, vydaný):");
        auto.Stav = Console.ReadLine();

        autoservis.Add(auto);
        Console.WriteLine("Automobil byl úspěšně přidán.");
    }

    static void OpravitAutomobil()
    {
        Console.WriteLine("Zadejte pozici automobilu pro opravu:");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < autoservis.Count)
        {
            Auto auto = autoservis[index];
            auto.Stav = "opravený";
            Console.WriteLine("Automobil byl opraven.");
        }
        else
        {
            Console.WriteLine("Neplatná pozice automobilu.");
        }
    }

    static void VypisInformaceOAutomobilech()
    {
        for (int i = 0; i < autoservis.Count; i++)
        {
            Auto auto = autoservis[i];
            Console.WriteLine($"Automobil {i + 1}:");
            Console.WriteLine($"Výrobce: {auto.Vyrobce}");
            Console.WriteLine($"Typ auta: {auto.TypAuta}");
            Console.WriteLine($"Rok výroby: {auto.RokVyroby}");
            Console.WriteLine($"Najeté kilometry: {auto.NajeteKilometry}");
            Console.WriteLine($"Stav: {auto.Stav}");
            Console.WriteLine();
        }
    }

    static void SmazatZaznamAutomobilu()
    {
        Console.WriteLine("Zadejte pozici automobilu k smazání:");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < autoservis.Count)
        {
            autoservis.RemoveAt(index);
            Console.WriteLine("Automobil byl smazán.");
        }
        else
        {
            Console.WriteLine("Neplatná pozice automobilu.");
        }
    }
}
