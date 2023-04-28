namespace Lab_11
{
    //1
    public static class NumberPairExtensions
    {
        public static bool Pair(this int input)
        {
            return input % 2 == 0;
        }
    }
    //2
    public static class NumberNotPairExtensions
    {
        public static bool NotPair(this int input)
        {
            return input % 2 != 0;
        }
    }
    //3
    public static class NumberSimpleExtensions
    {
        public static bool Simple(this int input)
        {
            if (input <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
    //4
    public static class TextVowelsExtensions
    {
        public static int Vowels(this string input)
        {
            int k = 0;
            foreach (char c in input)
            {
                if ("aeiouyAEIOUY".Contains(c))
                {
                    k++;
                }
            }
            return k;
        }
    }
    //5
    public static class TextСonsonantsExtensions
    {
        public static int Сonsonants(this string input)
        {
            int k = 0;
            foreach (char c in input)
            {
                if ("qwrtpsdfghjklzxcvbnmQWRTPSDFGHJKLZXCVBNM".Contains(c))
                {
                    k++;
                }
            }
            return k;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            //1
            if (num.Pair())
            {
                Console.WriteLine("Number is pair");
            }
            //2
            if(num.NotPair())
            {
                Console.WriteLine("Number isn`t pair");
            }
            //3
            if (num.Simple())
            {
                Console.WriteLine("Number is simple");
            }
            else
            {
                Console.WriteLine("Number isn`t simple");
            }

            //4
            Console.Write("\nEnter text: ");
            string text1 = Console.ReadLine();
            int kvowels = text1.Vowels();
            Console.WriteLine($"String has {kvowels} vowels");

            //5
            Console.Write("\nEnter text: ");
            string text2 = Console.ReadLine();
            int kconsonants = text2.Сonsonants();
            Console.WriteLine($"String has {kconsonants} consonants");
        }
    }
}