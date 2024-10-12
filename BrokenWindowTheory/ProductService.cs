namespace BrokenWindowTheory;

public class ProductService
{
    private readonly List<Product> _products;
    private readonly List<Customer> _customers;

    public ProductService()
    {
        _products = new List<Product>();
        _customers = new List<Customer>();
    }

    public void AddProduct(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        _products.Add(product);
    }
    
    public void AddCustomer(Customer customer)
    {
        if (customer == null) throw new ArgumentNullException(nameof(customer));
        _customers.Add(customer);
    }

    public Product GetProductById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            Console.WriteLine($"Product with ID {id} not found.");
        }
        return product;
    }
    
    public Product GetCustomerById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            Console.WriteLine($"Product with ID {id} not found.");
        }
        return product;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }
}