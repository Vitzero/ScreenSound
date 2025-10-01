using ScreenSound.Menus;
using ScreenSound.Models;

internal class MenuLeave : Menu
{

    public void Execute(Dictionary<string, Band> registeredBand)
    {
        base.Execute(registeredBand);
        Console.WriteLine("\n\nByee =) ");
        Console.ReadKey();
    }
}