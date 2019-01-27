using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDividend
{
    public class Horse
    {
        public int HorseNum { get; set; }
        public int HorseName { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", HorseNum, HorseName);
        }
    }
}
