namespace WilliamOgThomaPP;

public class InventoryItem
{
    protected string _name;
    protected int _quantity;
    protected double _price;

    public InventoryItem(string name, int quantity, double price)
    {
        _name = name;
        _quantity = quantity;
        _price = price;
    }
    
    public string Name { get { return _name; } }
    public int Quantity { get { return _quantity; } }
    public double Price { get { return _price; } }
}