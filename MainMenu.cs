namespace WilliamOgThomaPP;

public class MainMenu
{
    List<InventoryItem> inventory = [
        new ElectronicItem("Electronic", 5, 123.23, 200, 300, 400, "asd"),
        new ClothingItem("asd", 3, 123.1, "green", "XXXXXL")
        ];

    public void Menu()
    {
        Inventory();
    }

    public void Inventory()
    {
        foreach(var item in inventory)
        {
            if( item is ElectronicItem e)
                Console.WriteLine($"Name: {e.Name} Quatity: {e.Quatity} Price: {e.Price} Watt: {e.Watt} Volt: {e.Volt} Amperage: {e.Amperage} Warrenty: {e.Warrenty}");
            if (item is ClothingItem c)
                Console.WriteLine($"Name: {c.Name} Quatity: {c.Quatity} Price: {c.Price} Color: {c.Color} Size: {c.Size}");
        }
    }
}