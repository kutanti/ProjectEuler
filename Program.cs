using System;
using ProjectEuler.Questions;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = Questions.Solution11.GetMaxProduct();
            Console.WriteLine(ans);
        }
    }
}
