﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IProduct
    {
        public void DescribeProduct();
        public string TypeOfTheProduct();
    }
}
