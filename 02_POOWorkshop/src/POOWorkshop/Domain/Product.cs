namespace POOWorkshop.Domain;

public class Product
{
    private string _name = string.Empty;
    public int Id { get; }
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name is required");
            if (value.Trim().Length < 3)
                throw new ArgumentException("Name must have at least 3 characters");
            _name = value.Trim();
        }
    }

    public decimal Price { get; private set; }
    public int Stock { get; private set; }

    public Product(int id, string name, decimal price, int stock)
    {
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id));
        Id = id;
        Name = name;
        SetPrice(price);
        SetStock(stock);
    }

    public Product(int id, string name)
        : this(id, name, 0m, 0) { }

    // Constructor con stock por defecto (10)
    public Product(int id, string name, decimal price)
        : this(id, name, price, 10) { }

    public void SetPrice(decimal price)
    {
        if (price < 0m)
            throw new ArgumentException("Price cannot be negative");
        Price = price;
    }

    public void SetStock(int stock)
    {
        if (stock < 0)
            throw new ArgumentException("Stock cannot be negative");
        Stock = stock;
    }

    // Método para aplicar descuento limitado del 0% al 50%
    public void ApplyDiscount(decimal percent)
    {
        if (percent < 0m || percent > 50m)
            throw new ArgumentOutOfRangeException(
                nameof(percent),
                "Discount must be between 0% and 50%"
            );

        var discountAmount = Price * (percent / 100m);
        SetPrice(Price - discountAmount);
    }

    public override string ToString() =>
        $"Product(Id={Id}, Name={Name}, Price={Price:C2}, Stock={Stock})";
}
