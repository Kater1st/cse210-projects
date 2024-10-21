using System.Collections.Generic;

public class Order
{
    private List<Product> Products { get; set; }
    private Customer OrderCustomer { get; set; }
    private const decimal ShippingDomestic = 5.00m;
    private const decimal ShippingInternational = 35.00m;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        OrderCustomer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.TotalCost();
        }
        total += OrderCustomer.LivesInUSA() ? ShippingDomestic : ShippingInternational;
        return total;
    }

    public string GetPackingLabel()
    {
        var label = new System.Text.StringBuilder();
        label.AppendLine("Packing Label:");
        foreach (var product in Products)
        {
            label.AppendLine(product.GetProductInfo());
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{OrderCustomer.GetCustomerInfo()}";
    }
}