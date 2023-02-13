using System;

public class Cart
{
    public void ShowOrderDetails(float billing)
    {
        Console.WriteLine($"Total (shipping included): ${billing}\n");
    }

    public void GenerateShippingLabel(string shippingLabel)
    {
        Console.WriteLine(shippingLabel);
    }

    public void GeneratePackagingLabel(string packagingLabel)
    {
        Console.WriteLine(packagingLabel);
    }
    public void DisplayCompleteReport(string shippingLabel, string packagingLabel, float billing)
    {
        GenerateShippingLabel(shippingLabel);
        GeneratePackagingLabel(packagingLabel);
        ShowOrderDetails(billing);
    }
}