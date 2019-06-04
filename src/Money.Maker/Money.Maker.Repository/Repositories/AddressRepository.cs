using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Interfaces;

namespace Money.Maker.Repository.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        private new readonly DataContext _context;

        public AddressRepository(DataContext context, IDbContextTransaction transaction)
            : base(context, transaction)
        {
            _context = context;
        }
    }
}