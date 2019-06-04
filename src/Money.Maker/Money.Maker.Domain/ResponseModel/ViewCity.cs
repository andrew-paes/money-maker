using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.ResponseModel
{
    public class ViewCity
    {
        public int CityId { get; set; }

        public string CityName { get; set; }

        public int StateId { get; set; }

        public string StateName { get; set; }
    }
}
