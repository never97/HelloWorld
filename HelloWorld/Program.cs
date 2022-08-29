using System;
using System.Globalization;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
			DateTime now = DateTime.Now;

			CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
			Console.WriteLine($"Hello World! {now.ToString()}");
		}
    }
}
