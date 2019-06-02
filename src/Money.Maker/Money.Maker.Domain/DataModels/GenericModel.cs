using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public abstract class GenericModel
    {
        protected GenericModel() { }

        protected GenericModel(DateTime? createdDate,
                            DateTime? modifiedDate)
        {
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
        }

        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
