using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const float _USAShippingCost = 5.0f;
    private const float _InternationalShippingCost = 35.0f;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public float CalculateTotalCost()
    {
        float totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.IsAnUSAAddress())
        {
            totalCost += _USAShippingCost;
        }
        else
        {
            totalCost += _InternationalShippingCost;
        }
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        return label;
    }
}