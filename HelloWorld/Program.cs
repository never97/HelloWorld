using System;
using System.IO;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText(@"C:\repos\Greeting.txt", "Hello world!" + Environment.NewLine);
        }
    }
}
