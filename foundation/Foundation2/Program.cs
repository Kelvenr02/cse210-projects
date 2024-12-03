using System;

class Program
{
    static void Main(string[] args)
    {
        Address _address = new Address("R. Salvino Martins de Souza, 156 - Mangabeira", "João Pessoa", "PB", 58056060, "BRA");
        Customer _customer = new Customer("Kelven Rodrigues", _address);
        Order _order = new Order(_customer);

        Product product1 = new Product("GPU", "0001", 765.56f, 3);
        Product product2 = new Product("CPU", "0002", 376.69f, 7);

        _order.AddProduct(product1);
        _order.AddProduct(product2);

        float totalCost = _order.CalculateTotalCost();

        Console.WriteLine(_order.GetPackingLabel());
        Console.WriteLine(_order.GetShippingLabel());
        Console.WriteLine($"Total Cost: {totalCost:C}");
    }
}