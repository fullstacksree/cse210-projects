using System;

public class Connector
{
    
    private List<Order> _ordersList;
    private Cart _cart;
    public Connector()
    {
        _ordersList = new List<Order>();
        _cart = new Cart();
    }   
    public void TakeOrder(List<Product> productsList, Customer customer, float shippingCost)
    {
        Order order = new Order(productsList, customer, shippingCost);
        _ordersList.Add(order);
    }
    
    public void Run()
    {
        List<List<string>> productNames = new List<List<string>> {
            new List<string>{ "Red Roses", "Pink Boquet" },
            new List<string>{ "Pink Roses", "Yellow Roses", "Flower Boquet" },
            new List<string>{ "Polo Cap", "Black Hoody", "Golf Gloves" }
        };
        
        List<List<string>> productIds = new List<List<string>> {
            new List<string>{"000AL01", "000BB01" },
            new List<string>{"000AL03", "000AL04", "000BB03" },
            new List<string>{"000PC02", "000HB02", "000GL05" }
        };
        
        List<List<float>> productPrices = new List<List<float>> {
            new List<float>{05f, 08f},
            new List<float>{05f, 05f, 08f},
            new List<float>{15f, 50f, 25f}
        };
        
        List<List<int>> productQuantities = new List<List<int>> {
            new List<int>{2, 1},
            new List<int>{2, 2, 1},
            new List<int>{2, 2, 1},
        };

         
        List<List<Product>> productsCollectionList = new List<List<Product>>();

        
        for (int i = 0; i < productNames.Count(); i++)
        {
            productsCollectionList.Add(new List<Product>());
        }

        string packagingLabel;
        List<string> packagingLabelsList = new List<string>();

        for (int i = 0; i < productNames.Count(); i++)
        {
            packagingLabel = "";

            for (int k = 0; k < productNames[i].Count(); k++)
            {
                productsCollectionList[i].Add(new Product(productNames[i][k], productIds[i][k], productPrices[i][k], productQuantities[i][k]));
                packagingLabel += $"\nItem: {productNames[i][k]} | UPC: {productIds[i][k]}\n";
            }

            packagingLabelsList.Add(packagingLabel);
        }

        List<string> streetsList = new List<string> { "18th Street NW", "Slauson Avenue", "Dwarakanagar Lane5" };
        List<string> citiesList = new List<string> { "Washington DC", "Los Angeles", "Vizag" };
        List<string> statesList = new List<string> { "WA", "CA", "Andhra Pradesh" };
        List<string> countriesList = new List<string> { "USA", "USA", "India" };

        List<Address> addressesList = new List<Address>();

        List<string> customerNamesList = new List<string> { "Dale Little", "John Davis", "Nithin Kanes" };

        for (int i = 0; i < streetsList.Count(); i++)
        {
            addressesList.Add(new Address(streetsList[i], citiesList[i], statesList[i], countriesList[i]));
        }

        
        List<Customer> customersList = new List<Customer>();
        
        List<string> shippingLabelsList = new List<string>();

        string shippingLabel;

        
        for (int i = 0; i < customerNamesList.Count(); i++)
        {
            
            customersList.Add(new Customer(customerNamesList[i], addressesList[i]));
            shippingLabel = $"\nName: {customerNamesList[i]}\nAddress: {streetsList[i]}, {citiesList[i]}, {statesList[i]}, {countriesList[i]}";
            shippingLabelsList.Add(shippingLabel);
        }

        
        List<float> shippingCostsList = new List<float>();
       
        List<float> billingList = new List<float>();
        float shippingCost;
        float billing;

        
        for (int i = 0; i < productsCollectionList.Count(); i++)
        {
            shippingCost = customersList[i].GetAddress().GetCountry() == "USA" ? 5f : 35f;
            TakeOrder(productsCollectionList[i], customersList[i], shippingCost);
            billing = _ordersList[i].ComputeBilling();
            billingList.Add(billing);
        }

        for (int i = 0; i < _ordersList.Count(); i++)
        {
            _cart.DisplayCompleteReport(shippingLabelsList[i], packagingLabelsList[i], billingList[i]);
        }

    }

}