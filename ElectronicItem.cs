namespace WilliamOgThomaPP;

public class ElectronicItem : InventoryItem, ISellable
{
    private int _watt, _volt, _amperage;
    private string _warrenty;

    public ElectronicItem(string name, int quatity, double price, int watt, int volt, int amperage, string warrenty) :
        base(name, quatity, price)
    {
        _watt = watt;
        _volt = volt;
        _amperage = amperage;
        _warrenty = warrenty;
    }
    
    public int Watt { get { return _watt; } }
    public int Volt { get { return _volt; } }
    public int Amperage { get { return _amperage; } }
    public string Warrenty { get { return _warrenty; } }
    public int Quantity { get { return _watt; } }
    
    public double CalculatePrice(int percentage)
    {
        return _price * percentage / 100;
    }
}