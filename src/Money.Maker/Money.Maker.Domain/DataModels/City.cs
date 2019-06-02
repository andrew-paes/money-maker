using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class City
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public State State { get; set; }
    }
}
