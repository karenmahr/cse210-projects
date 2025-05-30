using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
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

    private string PackingLabel(Product product)
    {
        _products.Add(product);
        string label = "PackingLabel";
        foreach (var element in _products)
        {
            label += $"{product.GetName()} {product.GetProductId()}";
        }
        return label;

    }

    private string ShippingLabel()
    {
        return $"{_customer.GetName()} {_customer.GetAddress()}";
    }
}