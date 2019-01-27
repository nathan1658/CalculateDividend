using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDividend
{
   

    public abstract class BasePool
    {

        public string PoolName { get; set; }
        public int[] WinningCombination { get; set; }
        public double Dividend { get; set; }

        public BasePool(string poolName, int[] winningCombination, double dividend)
        {
            PoolName = poolName;
            WinningCombination = winningCombination;
            Dividend = dividend;
        }

        public abstract double GetDividend(int[] input);


    }

    public class WinPool : BasePool
    {
        public WinPool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            if (WinningCombination[0] == input[0])
                return Dividend;
            return 0;
        }
    }
    public class PlacePool : BasePool
    {
        public PlacePool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            if (input.Take(3).Contains(WinningCombination[0]))
                return Dividend;
            return 0;
        }
    }

    public class QuinellaPool : BasePool
    {
        public QuinellaPool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            var filteredInput = input.Take(2);
            foreach(var val in WinningCombination)
            {
                if (!filteredInput.Contains(val))
                    return 0;
            }
            return Dividend;
            
        }
    }

    public class QuinellaPlacePool : BasePool
    {
        public QuinellaPlacePool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            var filteredInput = input.Take(3).ToList();
            
            for (int i = 0; i < WinningCombination.Length; i++)
            {
                var value = WinningCombination[i];
                if (!filteredInput.Contains(value))
                    return 0;
            }
            return Dividend;
        }
    }


    public class TiercePool : BasePool
    {
        public TiercePool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            var filteredInput = input.Take(3).ToList();
            for (int i = 0; i < 3; i++)
            {
                if (input[i] != WinningCombination[i])
                    return 0;
            }
            return Dividend;
        }
    }


    public class TrioPool : BasePool
    {
        public TrioPool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            var filteredInput = input.Take(3).ToList();
            foreach(var value in WinningCombination)
            {
                if (!filteredInput.Contains(value))
                    return 0;
            }
            return Dividend;
        }
    }

    public class First4Pool : BasePool
    {
        public First4Pool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            var filteredInput = input.Take(4).ToList();
            foreach (var value in WinningCombination)
            {
                if (!filteredInput.Contains(value))
                    return 0;
            }
            return Dividend;
        }
    }

    public class QuartetPool : BasePool
    {
        public QuartetPool(string poolName, int[] winningCombination, double dividend) : base(poolName, winningCombination, dividend)
        {
        }

        public override double GetDividend(int[] input)
        {
            var filteredInput = input.Take(4).ToList();
            for (int i = 0; i < 4; i++)
            {
                if (input[i] != WinningCombination[i])
                    return 0;
            }
            return Dividend;
        }
    }

}
