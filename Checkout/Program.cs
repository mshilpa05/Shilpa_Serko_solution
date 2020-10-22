using System;

namespace Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            Till myTill = new Till();
            myTill.Scan("AB");
            Console.WriteLine(myTill.Total());
        }
    }
}
