﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LABA2_OOP
{
    [Serializable]
    [DataContract]
    class Xiaomi : Phones
    {
        [DataMember]
        public String PhoneModel
        {
            get; set;
        }

        public Xiaomi(string name, DateTime repairStartDate, string number, Address address, double estimatedCost, string phonemodel)
            : base(name, repairStartDate, number, address, estimatedCost)
        {
            PhoneModel = phonemodel;
        }
    }
}