using System;

public class Order
{
    private List<Product> _productsList;
    private Customer _customer;
    private float _shippingCost;
    public Order(List<Product> productsList, List<Order> ordersList, Customer customer, float shippingCost)
    {
        _productsList = productsList;
        _customer = customer;
        _shippingCost = shippingCost;
    }
    public List<Product> GetProductsList()
    {
        return _productsList;
    }
    public void SetProductList(List<Product> productsList)
    {
        _productsList = productsList;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public float GetShippingCost()
    {
        return _shippingCost;
    }
    public void SetShippingCost(float shippingCost)
    {
        _shippingCost = shippingCost;
    }
    public float ComputeBilling()
    {
        float productsCost = 0;
        foreach (Product product in _productsList)
        {
            productsCost += product.ComputeTotalPrice();
        }
        return productsCost * _shippingCost;
    }
    
}