using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hotel
{
    public class Utility
    {
        public static bool IsOverlapping(DateTime aStart, DateTime aEnd, DateTime bStart, DateTime bEnd)
        {
            return (aStart < bEnd && bStart < aEnd);
        }
    }
}
