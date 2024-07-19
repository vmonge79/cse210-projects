public class Order
{
    private float _totalCost = 0;
    private Customer _customer;
    private Address _address;
    private int _localShip = 5;
    private int _foreignShip = 35;
    private Dictionary<Product, int> _products = new Dictionary<Product, int>();

    public int GetLocalShip()
    {
        return _localShip;
    }

    public void SetLocalShip(int localShip)
    {
        _localShip = localShip;
    }

    public int GetForeignShip()
    {
        return _foreignShip;
    }

    public void SetForeignShip(int foreignShip)
    {
        _foreignShip = foreignShip;
    }

    private bool IsUSA()
    {
        return _address.GetCountry().Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public float GetTotalCost() => _totalCost;

    public void SetTotalCost()
    {
        _totalCost = 0;
        foreach (var item in _products)
        {
            var product = item.Key;
            var prodQ = item.Value;

            _totalCost += product.CalculateProductTotalPrice(prodQ);
        }

        if (IsUSA())
        {
            _totalCost += _localShip;
        }
        else
        {
            _totalCost += _foreignShip;
        }
    }


    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    public void AddProductToOrder(Product product, int quantity)
    {
        if (_products.ContainsKey(product))
        {
            _products[product] += quantity;
        }
        else
        {
            _products.Add(product, quantity);
        }
    }

    public void DisplayPackingLabel()
    {
        foreach (var item in _products)
        {
            var product = item.Key;
            var quantity = item.Value;

    
            Console.WriteLine($"{quantity} | {product.GetProdName()} | ${product.CalculateProductTotalPrice(quantity)}");
        }
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Shipping Cost: ${(IsUSA() ? _localShip : _foreignShip)}");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Total Order Cost: ${CalculateTotalCost()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine("------------------------------");
        
    }


    public void DisplayShippingLabel()
    {
        Console.WriteLine("Ship to:");
        Console.WriteLine(_customer.GetName());
        _address.DisplayCompleteAddress();
    }

    public float CalculateTotalCost()
    {
        SetTotalCost();
        return _totalCost;
    }
}
