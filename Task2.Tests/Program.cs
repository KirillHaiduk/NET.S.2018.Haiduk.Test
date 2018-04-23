using System;
using Task_2.Solution;

namespace Task2.Tests
{
    public class Program
    {
        static void Main()
        {
            var charsGenerator = new RandomCharsFileGenerator();
            var bytesGenerator = new RandomBytesFileGenerator();
            charsGenerator.GenerateFiles(2, 20);
            bytesGenerator.GenerateFiles(2, 20);            
            Console.ReadLine();
        }
    }
}
