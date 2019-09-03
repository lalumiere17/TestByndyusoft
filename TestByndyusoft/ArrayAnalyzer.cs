using System;
using System.Collections;

namespace TestByndyusoft
{
    public class ArrayAnalyzer
    {
        public static bool IsNumber(object item)
        {
            bool isnum;
            if ((item is string) || (item is char) || (item is bool) || (item is null))
                isnum = false;
            else
                isnum = true;
            return isnum;
        }

        public static double SumOfMins(ArrayList _array)
        {
            if (_array is null)
                throw new ArgumentNullException("List is null");
            if (_array.Count == 0)
                throw new ArgumentException("List is empty");
            if (_array.Count < 2)
                throw new ArgumentException("List is too short");

            if (!((IsNumber(_array[0])) || (IsNumber(_array[1]))))
                throw new ArgumentException("List does not consist only of numbers");
            double min1 = Math.Min(Convert.ToDouble(_array[0]), Convert.ToDouble(_array[1]));
            double min2 = Math.Max(Convert.ToDouble(_array[0]), Convert.ToDouble(_array[1]));

            for (int i = 2; i < _array.Count; i++)
            {
                if (!(IsNumber(_array[i])))
                    throw new ArgumentException("List does not consist only of numbers");

                double item = Convert.ToDouble(_array[i]);
                if (item <= min1)
                {
                    min2 = min1;
                    min1 = item;
                }
                else if (item <= min2)
                    min2 = item;
            }

            double res = min1 + min2;
            return res;
        }
    }
}
