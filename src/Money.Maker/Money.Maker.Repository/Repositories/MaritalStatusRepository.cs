using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Interfaces;

namespace Money.Maker.Repository.Repositories
{
    public class MaritalStatusRepository : GenericRepository<MaritalStatus>, IMaritalStatusRepository
    {
        private new readonly DataContext _context;

        public MaritalStatusRepository(DataContext context, IDbContextTransaction transaction)
            : base(context, transaction)
        {
            _context = context;
        }
    }
}