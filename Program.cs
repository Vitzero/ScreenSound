
using ScreenSound.Menus;
using ScreenSound.Models;
Dictionary<string, Band> RegisteredBands = new Dictionary<string, Band>();

Band Beatles = new Band("The Beatles");

Band ira = new Band("Ira!");
ira.AddGrade(new Review(10));
ira.AddGrade(new Review(8));
ira.AddGrade(new Review(7));
RegisteredBands.Add(ira.Name, ira);

Dictionary<int, Menu> optionsMenu = new();
optionsMenu.Add(1, new MenuRegisterBand());
optionsMenu.Add(2, new MenuRegisterAlbumBand());
optionsMenu.Add(3, new MenuAllBandsRegistereds());
optionsMenu.Add(4, new MenuRateBand());
optionsMenu.Add(5, new MenuRateAlbum());
optionsMenu.Add(6, new MenuShowDetails());
optionsMenu.Add(-1, new MenuLeave());


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
    System.Console.WriteLine("\nWrite 1 to register a band");
    System.Console.WriteLine("Write 2 to register an album for a Band");
    System.Console.WriteLine("Write 3 to show all bands");
    System.Console.WriteLine("Write 4 to rate a band");
    System.Console.WriteLine("Write 5 to rate a Album from some Band");
    System.Console.WriteLine("Write 6 to show the average rating of a band");
    System.Console.WriteLine("Write -1 to leave\n");

    Console.WriteLine("Choose a option:");
    int option = int.Parse(Console.ReadLine());

    if (optionsMenu.ContainsKey(option))
    {
        Menu menuToShow = optionsMenu[option];
        menuToShow.Execute(RegisteredBands);
        if(option > 0) ShowOptions();
    }
    else Console.WriteLine("Invalid input");

}

ShowOptions();