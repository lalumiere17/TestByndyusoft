using System;
using System.Collections.Generic;

namespace TestByndyusoft
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = 30;
            Random rand = new Random();
            List<int> arr = new List<int>();
            for(int i=0; i<N; i++)
            {
                //arr.Add(rand.Next(-100, 100));
                arr.Add('t');
                Console.WriteLine(arr[i].GetType());

            }
            try
            {
                int resSum = SumOfMins(arr);
                Console.WriteLine("Anwer is " + resSum.ToString());
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Array is empty!");

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is NULL");
            }
            Console.ReadLine();
        }

        public static int SumOfMins (List<int> _array)
        {
            if (_array.Count == 0)
            {
                throw new ArgumentException();
            }
            if (_array == null)
            {
                throw new NullReferenceException();
            }
            _array.Sort();
            int res = _array[0] + _array[1];
            return res;
        }
    }
}
