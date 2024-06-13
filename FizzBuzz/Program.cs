namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nmbrs = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
            26, 27, 28, 29, 30};

            foreach (int n in nmbrs)
            {
                string Fizz = (n % 3 == 0 && n % 5 == 0) ? "FIZZBUZZ"
                            : (n % 5 == 0 && n % 3 != 0 ? "BUZZ"
                            : (n % 3 == 0 && n % 5 != 0 ? "FIZZ"
                            : n.ToString()));

                Console.Write(Fizz + ", ");
            }

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            //    int i = 0;
            //    int cubed = 0;


            //while (true) 
            //{

            //    if (ints[i] % 2 != 0)
            //    {

            //        cubed = Math.Pow(ints[i], 3);
            //        Console.WriteLine(cubed);

            //    } 
            //        i++;

            //    if (i >= 25) { break; }
            //}   

        }
    }
}
