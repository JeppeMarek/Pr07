namespace Menu;

public class Menu
{
    public string Title;
    public MenuItem[] MenuItems = new MenuItem[0];
    public int ItemCount = 0;

    public void Show()
    {
        for (int i = 0; i < ItemCount; i++)
        {
            Console.WriteLine(MenuItems[i].Title);
        }

        Console.WriteLine("\nVælg et menupunkt eller tryk på 0 for at afslutte");
    }
}