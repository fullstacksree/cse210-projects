using System;

public class Cart
{
    public void DisplayOrderDetails(float billing)
    {
        Console.WriteLine($"Total (shipping included): ${billing}\n");
    }

    public void DisplayShippingLabel(string shippingLabel)
    {
        Console.WriteLine(shippingLabel);
    }

    public void GeneratePackagingLabel(string packagingLabel)
    {
        Console.WriteLine(packagingLabel);
    }
    public void DisplayCompleteReport(string shippingLabel, string packagingLabel, float billing)
    {
        DisplayShippingLabel(shippingLabel);
        GeneratePackagingLabel(packagingLabel);
        DisplayOrderDetails(billing);
    }
}