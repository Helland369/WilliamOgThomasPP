namespace WilliamOgThomaPP;

public class hei
{
    private List<InventoryItem> items = new List<InventoryItem>
    {
        new ClothingItem("T-shirt", 5, 200.99,"Green","L"),
        new ClothingItem("Pants", 3, 689.50,"Black","M"),
        new ClothingItem("Shirt", 10, 300.50,"White","XL"),
        new ClothingItem("Socks", 20, 150.50,"Grey","40-48"),
        new ElectronicItem("Keyboard",10,800.99,2,12,2,"Life time warranty"),
        new ElectronicItem("Mouse",6,300.95,3,12,1,"Life time warranty"),
        new ElectronicItem("Headphones",30,900.99,1,12,1,"Life time warranty"),
        new ElectronicItem("CPU",10,2500.99,140,12,3,"Life time warranty"),
        new ElectronicItem("GPU",12,6000,300,16,3,"Life time warranty"),
    };
}