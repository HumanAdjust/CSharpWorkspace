using System;

namespace Example06
{
    class Program
    {
        static void FullSequenceOfLetters(string a)
        {
            for (int i = (char)a[0]; i <= (char)a[1]; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            FullSequenceOfLetters("ds");
            FullSequenceOfLetters("or");
        }
    }
}
