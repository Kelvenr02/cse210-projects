using System;

public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name; // Verificar se posso tirar this.
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public string GetName()
    {
        return _name;
    }
}