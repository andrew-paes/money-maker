﻿using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Interfaces;

namespace Money.Maker.Repository.Repositories
{
    public class GenderRepository : GenericRepository<Gender>, IGenderRepository
    {
        private new readonly DataContext _context;

        public GenderRepository(DataContext context, IDbContextTransaction transaction)
            : base(context, transaction)
        {
            _context = context;
        }
    }
}