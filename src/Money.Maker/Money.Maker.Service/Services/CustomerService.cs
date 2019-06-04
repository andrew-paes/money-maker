using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Repositories;
using Money.Maker.Service.Interfaces;

namespace Money.Maker.Service.Services
{
    public class CustomerService : GenericService<Customer, CustomerRepository>, ICustomerService
    {

    }
}