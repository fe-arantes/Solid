using Application.Interfaces;
using Application.Repositories;

namespace Application.Infrastructure;

public class CustomerDataAccess : ICustomerDataAccess
{
    CustomerRepository _customerRepository { get; } = new();

    public string GetCustomerName(int id)
    {
        var name = _customerRepository.GetCustomerNameById(id);
        return name;
    }
}
