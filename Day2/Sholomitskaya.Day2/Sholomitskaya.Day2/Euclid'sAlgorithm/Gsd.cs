using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace EuclidsAlgorithm
{
    public static class GreatestCommonDivisor
    {
        public static long Gcd(long a, long b, out long time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;
            return Math.Abs(a);
        }
        public static long Gcd(long a, long b, long c, out long time)
        {
            long tempTime;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long result = Gcd(c, Gcd(a, b, out tempTime), out tempTime);
            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;
            return result;
        }
        public static long Gcd(out long time, params long[] values)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long tempTime;
            long GcdResult;
            long tempResult;
            var result = new List<long>();
            for (int i = 0; i < values.Length; i++)
            {
                result.Add(values[i]);
            }
            while (result.Count != 2)
            {
                for (int i = 0; i < result.Count;i++)
                {
                    if (result[i]== 0) result[i]=1;
                }
                tempResult = Gcd(result[0], result[1], out tempTime);
                result.Add(tempResult);
                result.RemoveAt(0);
                result.RemoveAt(1);

            }
            GcdResult = Gcd(result[0], result[1], out tempTime);
            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;
            return GcdResult;
        }
        public static long BinaryGcd(long a, long b, out long time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long k = 1;
              while ((a != 0) && (b != 0))
            {
                while ((a % 2 == 0) && (b % 2 == 0))
                {
                    a /= 2;
                    b /= 2;
                    k *= 2;
                }
                while (a % 2 == 0) a /= 2;
                while (b % 2 == 0) b /= 2;
                if (a >= b) a -= b; else b -= a;
            }
            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;
            if (a == 0)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            return b * k;
        }
        public static long BinaryGcd(long a, long b, long c, out long time)
        {
            long result;
            long tempTime;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            result=BinaryGcd(c, BinaryGcd(a, b, out tempTime),out tempTime);
            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;
            return result;
        }
        public static long BinaryGcd(out long time, params long[] values)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long tempTime;
            long GcdResult;
            long tempResult;
            var result = new List<long>();
            for (int i = 0; i < values.Length; i++)
            {
                result.Add(values[i]);
            }
            while (result.Count != 2)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] == 0) result[i] = 1;
                }
                tempResult = BinaryGcd(result[0], result[1], out tempTime);
                result.Add(tempResult);
                result.RemoveAt(0);
                result.RemoveAt(1);
            }
            GcdResult = Gcd(result[0], result[1], out tempTime);
            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;
            return GcdResult;
        }
    }
}