
using ScreenSound.Models;
Dictionary<string, Band> RegisteredBands = new Dictionary<string, Band>();

Band Beatles = new Band("The Beatles");

Band ira = new Band("Ira!");
ira.AddGrade(new Review(10));
ira.AddGrade(new Review(8));
ira.AddGrade(new Review(7));
RegisteredBands.Add(ira.Name, ira);

string WelcomeMessage = @"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ";

void ShowWelcomeMessage()
{
    System.Console.WriteLine(WelcomeMessage);
}

void ShowOptions()
{
    Console.Clear();
    ShowWelcomeMessage();
    System.Console.WriteLine("\nWrite 1 to register some band");
    System.Console.WriteLine("Write 2 to register a Album of some Band");
    System.Console.WriteLine("Write 3 to show all bands");
    System.Console.WriteLine("Write 4 to rate some band");
    System.Console.WriteLine("Write 5 to show the average of some band");
    System.Console.WriteLine("Write -1 to leave\n");

    Console.WriteLine("Choose one option:");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {

        case 1:
            RegisterBand();
            break;
        case 2:
            RegisterAlbumBand();
            break;
        case 3:
            ShowAllBands();
            break;
        case 4:
            rateSomeBand();
            break;
        case 5:
            AverageBand();
            break;
        case -1:
            Console.WriteLine("\n\nByee =) ");
            Thread.Sleep(1500);
            break;
        default:
            Console.WriteLine("This isnt a option. Retry!");
            break;
    }

}

void RegisterBand()
{
    Console.Clear();
    ShowTitleOption("Register Band");
    Console.Write("Write the band name that you want to register: ");
    string BandName = Console.ReadLine()!;
    Band NewBand = new Band($"{BandName}");
    RegisteredBands.Add(BandName, NewBand);
    Console.WriteLine($"The Band {BandName} was registered");

    Thread.Sleep(2000);
    ShowOptions();
}

void RegisterAlbumBand()
{
    Console.Clear();
    ShowTitleOption("Album register");
    Console.WriteLine("Write the Band's album name that you want to register:");
    string nameBand = Console.ReadLine();

    if (RegisteredBands.ContainsKey(nameBand))
    {
        Console.WriteLine("Write the album's name that you want to register:");
        string titleAlbum = Console.ReadLine()!;
        RegisteredBands[nameBand].AddAlbum(new Album(titleAlbum));
    }
}

void ShowAllBands()
{
    Console.Clear();
    ShowTitleOption("Registered Bands");
    foreach (string band in RegisteredBands.Keys)
    {
        Console.WriteLine($"-> {band}");
    }
    Console.WriteLine("\nClick some key to return to the menu.");
    Console.ReadLine();
    ShowOptions();
}

void ShowTitleOption(string titulo)
{
    int qtdLetters = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetters, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
    Console.WriteLine();
}

void rateSomeBand()
{
    Console.Clear();
    Console.WriteLine("Write the band name that you want to rate:");
    string name = Console.ReadLine();

    if (RegisteredBands.ContainsKey(name))
    {
        Console.WriteLine($"Write the grade that band {name} deserves:");
        Review grade = Review.Parse(Console.ReadLine());
        RegisteredBands[name].AddGrade(grade);
        Console.WriteLine($"The grade: {grade.Grade} was sucessfully registered to the band: {name}");
    }
    else
    {
        Console.WriteLine($"The Band name '{name}' is wrong, please try again.");
    }
    Console.WriteLine("Click any bind to return.");
    Console.ReadKey();
    ShowOptions();

}

void AverageBand()
{
    Console.Clear();
    ShowTitleOption("Average of Band");

    Console.WriteLine("Write the band name that you wises see the average review");
    string name = Console.ReadLine();

    if (RegisteredBands.ContainsKey(name))
    {
        double media = RegisteredBands[name].Average;
        Console.WriteLine($"The average review of {name} is: {media:F2}");
    }
    else
    {
        Console.WriteLine("The name is wrong, check-up and retry.");
    }
    Console.WriteLine("Click some bind to return.");
    Console.ReadKey();
    ShowOptions();
}

ShowOptions();