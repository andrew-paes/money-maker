﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Money.Maker.Domain.DataModels
{
    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String SocialCode { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Address Address { get; set; }
        public City BirthPlace { get; set; }
        public List<Product> Products { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}