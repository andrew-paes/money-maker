using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class Transaction
    {
        public int Id { get; set; }
        public Boolean Type { get; set; }
        public Decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}