using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    private int TotalCostOrder()
    {
        int totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCostProduct();
        }
        return totalCost + _customer.GetShippingCost();
    }

    public int GetTotalCostOrder()
    {
        return TotalCostOrder();
    }

    private string PackingLabel()
    {
        string label = "Packing Label\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return label;
    }
    public string GetPackingLabel()
    {
        return PackingLabel();
    }

    private string ShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()} - {_customer.GetAddress().GetCompleteAddress()}";
    }

    public string GetShippingLabel()
    {
        return ShippingLabel();
    }
}