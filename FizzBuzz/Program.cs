namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 30; n++) //use for loop to iterate through the number 1-30 
            {
                string Fizz = (n % 3 == 0 && n % 5 == 0) ? $"{n}: FIZZBUZZ" 
                            : (n % 5 == 0 ? $"{n}: BUZZ" 
                            : (n % 3 == 0 ? $"{n}: FIZZ"
                            : n.ToString() ));

                Console.Write(Fizz + ", ");  
            }
        }
    }
}

