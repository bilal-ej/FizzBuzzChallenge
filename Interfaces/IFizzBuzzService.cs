using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge.Interfaces
{
    public interface IFizzBuzzService
    {
        void FizzBuzz();
        string GetFizzBuzzMessage(int i);
    }
}
