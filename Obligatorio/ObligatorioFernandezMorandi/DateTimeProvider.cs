using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DateTimeProvider
    {
        private static DateTime? now;
        public static DateTime Now
        {
            get
            {
                bool nowIsNotSet = now == null;
                if (nowIsNotSet)
                {
                    return DateTime.Now;
                }
                else
                {
                    return (DateTime)now;
                }
            }
            set
            {
                now = value;
            }
        }
    }
}
