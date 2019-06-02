using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class Address
    {
        public int Id { get; set; }
        public String Street { get; set; }
        public int Number { get; set; }
        public City City { get; set; }
    }
}
