using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class Product : GenericModel
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Decimal ManagementFee { get; set; }
        public Decimal IncomeTax { get; set; }
    }
}