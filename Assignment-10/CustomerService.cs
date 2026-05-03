public interface ICustomerRepository
{
    string GetCustomerName();
}

public class CustomerService
{
    private readonly ICustomerRepository repo;

    public CustomerService(ICustomerRepository repo)
    {
        this.repo = repo;
    }

    public string GetName()
    {
        return repo.GetCustomerName();
    }
}