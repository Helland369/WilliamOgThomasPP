namespace WilliamOgThomaPP;

public class ClothingItem : InventoryItem, ISellable
{
    private string _colour, _size;

    public ClothingItem(string name, int qualtity, double price, string colour, string size) : base(name, qualtity,
        price)
    {
        _colour = colour;
        _size = size;
    }
    
    public string Colour { get { return _colour; } }
    public string Size { get { return _size; } }
    
    public double CalculatePrice(int percentage)
    {
        return _price * percentage / 100;
    }
}