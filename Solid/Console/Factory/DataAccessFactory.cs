using Application.Infrastructure;
using Application.Interfaces;

namespace Application.Factory;

public class DataAccessFactory
{
    public static ICustomerDataAccess GetCustomerDataAcessObj() => new CustomerDataAccess();
}
