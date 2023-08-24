using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataBaseException : Exception
    {
        public DataBaseException(string message) : base(message)
        {

        }
    }
}
