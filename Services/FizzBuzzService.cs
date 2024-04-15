using FizzBuzzChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {

        public FizzBuzzService() { }

        public void FizzBuzz()
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetFizzBuzzMessage(i));
            }

        }

        public string GetFizzBuzzMessage(int i)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                return (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "");
            }
            else
            {
                return i.ToString();
            }
        }

    }
}
