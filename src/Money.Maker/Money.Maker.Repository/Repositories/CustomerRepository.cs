using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Interfaces;

namespace Money.Maker.Repository.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private new readonly DataContext _context;

        public CustomerRepository(DataContext context, IDbContextTransaction transaction)
            : base(context, transaction)
        {
            _context = context;
        }
    }
}