using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class State : GenericModel
    {
        public String Name { get; set; }
        public String Code { get; set; }
    }
}
