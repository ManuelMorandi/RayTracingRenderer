﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BusinessLogicException : Exception
    {
        public BusinessLogicException(string message) : base(message)
        {

        }
    }
}
