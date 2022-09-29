namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(ty));
        }

        public static string FizzBuzz(int x)
        {
            string output = "";
            for(int i = 1; i <= x; i++)
            {
                if(i%5 == 0 & i%3 == 0)
                {
                    output += "FizzBuzz ";
                }
                else if (i % 5 == 0)
                {
                    output += "Buzz ";
                }
                else if (i % 3 == 0)
                {
                    output += "Fizz ";
                }
                else
                {
                    output += i + " ";
                }
            }
            return output.Trim();
        }
    }
}