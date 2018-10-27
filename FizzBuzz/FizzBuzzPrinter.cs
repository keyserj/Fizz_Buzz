namespace FizzBuzz
{
    public class FizzBuzzPrinter
    {
        public void Print()
        {
            for (int i = 1; i <= 100; i++)
            {
                System.Console.WriteLine(GetLineFor(i));
            }
        }

        public string GetLineFor(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0)
            {
                result += "Fizz";
            }

            if (number % 5 == 0)
            {
                result += "Buzz";
            }

            if (result == string.Empty)
            {
                result = number.ToString();
            }
            return result;
        }
    }
}