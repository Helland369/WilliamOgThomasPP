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
}