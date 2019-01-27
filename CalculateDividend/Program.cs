using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDividend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BasePool> pools = new List<BasePool>();
           pools.Add(new WinPool("WinPool", new int[] { 6 }, 52.5));
           pools.Add(new PlacePool("PlacePool", new int[] { 6 }, 19.5));
           pools.Add(new PlacePool("PlacePool", new int[] { 2 }, 30));
           pools.Add(new PlacePool("PlacePool", new int[] { 3 }, 15));
           pools.Add(new QuinellaPool("QuinellaPool", new int[] { 2, 6 }, 292.5));
           pools.Add(new QuinellaPlacePool("QuinellaPlace", new int[] { 2, 6 }, 90.5));
           pools.Add(new QuinellaPlacePool("QuinellaPlace", new int[] { 3, 6 }, 39));
           pools.Add(new QuinellaPlacePool("QuinellaPlace", new int[] { 2, 3 }, 66));
           pools.Add(new TiercePool("TiercePool", new int[] { 6, 2, 3 }, 1758));
           pools.Add(new TrioPool("TrioPool", new int[] { 2, 3, 6 }, 291));
           pools.Add(new First4Pool("First4", new int[] { 2, 3, 6, 7 }, 178));
           pools.Add(new QuartetPool("QuartetPool", new int[] {6,2,3,7}, 4650));
            var sum = 0.0;
            foreach(var pool in pools)
            {
                sum += pool.GetDividend(new int[] { 6, 2, 3, 7 });
            }

            Console.WriteLine(sum);
        }
    }


    
}
