using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Decimal ManagementFee { get; set; }
        public Decimal IncomeTax { get; set; }
    }
}