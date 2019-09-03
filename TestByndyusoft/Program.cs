using System;
using System.Collections;

namespace TestByndyusoft
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ArrayList arr = new ArrayList();
            for (int i = 0; i < 30; i++)
                arr.Add(rand.Next(-30, 30));
            try
            {
                double resSum = ArrayAnalyzer.SumOfMins(arr);
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
    }
}
