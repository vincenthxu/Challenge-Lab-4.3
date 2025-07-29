namespace Challenge_Lab_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                char[] s = ['h', 'e', 'l', 'l', 'o'];
                StringReverse(ref s);
                Console.WriteLine(s);
            }
            else
            {
                foreach(var arg in args)
                {
                    char[] chars = arg.ToCharArray();
                    StringReverse(ref chars);
                    Console.WriteLine(chars);
                }
            }
        }

        static void StringReverse(ref char[] characters)
        {
            char temp;
            for (int i = 0; i < characters.Length / 2; i++)
            {
                temp = characters[i];
                characters[i] = characters[characters.Length - i - 1];
                characters[characters.Length - i - 1] = temp;
            }
        }
    }
}
