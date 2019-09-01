using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace TestByndyusoft
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ArrayList arr = new ArrayList();
            //for (int i = 0; i < 30; i++)
                arr.Add(rand.Next(-30, 30));
            try
            {
                double resSum = SumOfMins(arr);
                Console.WriteLine("Anwer is " + resSum.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        public static double SumOfMins(ArrayList _array)
        {
            if (_array is null) throw new NullReferenceException("List is null");
            if (_array.Count == 0) throw new ArgumentException("List is empty");
            if (_array.Count < 2) throw new ArgumentException("List is too short");

            ArrayList sorted_arr = new ArrayList();
            foreach (object item in _array)
            {
                if ((item is string) || (item is char) || (item is bool) || (item is null))
                    throw new ArgumentException("List does not consist only of numbers");
                double a = Convert.ToDouble(item);
                sorted_arr.Add(a);
            }
            
            sorted_arr.Sort();
            
            double res = (double)sorted_arr[0] + (double)sorted_arr[1];
            return res;
        }
    }
}
