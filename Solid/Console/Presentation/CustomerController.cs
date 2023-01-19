using Application.Factory;
using Application.Interfaces;

namespace Application.Presentation;

public class CustomerController
{
    ICustomerDataAccess _customerDataAccess;

    public CustomerController()
    {
        _customerDataAccess = DataAccessFactory.GetCustomerDataAcessObj();
    }

    public string GetCustomerName(int id)
    {
        return _customerDataAccess.GetCustomerName(id);
    }
}
