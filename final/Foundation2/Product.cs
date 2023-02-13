using System;
using System.Collections.Generic;

public class Product
{
    private string _productName;
    private string _productID;
    private float _productPrice;
    private int _quantity;

    public Product(string productName, string productID, float productPrice, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }
    public float GetProductPrice()
    {
        return _productPrice;
    }
    public void SetProductPrice(float productPrice)
    {
        _productPrice = productPrice;
    }
    public int GetQuantity()
    {
        return _quantity;        
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public float ComputeTotalPrice()
    {
        return _productPrice * _quantity;
    }
    
}