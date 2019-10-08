﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
	[DataContract]
    public class Product
    {
		[DataMember]
		public string Category { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public int Count { get; set; }
		

        public override string ToString()
        {
            return Name;
        }
    }
}
