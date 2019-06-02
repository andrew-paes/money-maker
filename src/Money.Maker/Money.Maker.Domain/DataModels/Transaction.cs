using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class Transaction : GenericModel
    {
        public Boolean Type { get; set; }
        public Decimal Amount { get; set; }
    }
}