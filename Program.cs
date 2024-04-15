using FizzBuzzChallenge.Services;

public class Program
{
    static void Main(string[] args)
    {
        // instantiate service class containing the FizzBuzz method
        FizzBuzzService fizzBuzzService = new FizzBuzzService();

        // Call FizzBuzz method
        fizzBuzzService.FizzBuzz();
    }
}