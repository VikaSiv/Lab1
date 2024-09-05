// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public abstract class Product
{
    public virtual decimal Price { get; set; }

    public abstract string GetInformation();
}

public class Toy : Product
{
    public string Material { get; set; }

    public override decimal Price
    {
        get => base.Price;
        set => base.Price = value;
    }

    public override string GetInformation()
    {
        return $"Toy: Material = {Material}, Price = {Price:C}";
    }
}

public class Meat : Product
{
    public double Weight { get; set; } // в килограммах

    public override string GetInformation()
    {
        return $"Meat: Weight = {Weight} kg, Price = {Price:C}";
    }
}

public class Drinks : Product
{
    public int Volume { get; set; } // в миллилитрах

    public override string GetInformation()
    {
        return $"Drink: Volume = {Volume} ml, Price = {Price:C}";
    }
}

public class Fruits : Product
{
    public string Type { get; set; }

    public override string GetInformation()
    {
        return $"Fruit: Type = {Type}, Price = {Price:C}";
    }
}

public class Vegetables : Product
{
    public string Color { get; set; }

    public override string GetInformation()
    {
        return $"Vegetable: Color = {Color}, Price = {Price:C}";
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Toy { Material = "Plastic", Price = 14.96m},
            new Meat { Weight = 1.8, Price = 30.50m},
            new Drinks { Volume = 500, Price = 2.99m},
            new Fruits { Type = "Orange", Price = 6.20m},
            new Vegetables { Color = "Green", Price = 0.60m}
        };

        // Вывод информации о товарах с учетом скидки
        decimal discountRate = 0.1m; // 10% скидка

        foreach (var product in products)
        {
            decimal discountedPrice = product.Price * (1 - discountRate);
            Console.WriteLine($"{product.GetInformation()}, Discounted Price = {discountedPrice:C}");
        }
    }
}

