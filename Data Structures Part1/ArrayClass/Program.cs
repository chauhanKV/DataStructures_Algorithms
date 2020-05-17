using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);
            
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.removeAt(2);
            Console.WriteLine("index of : "+numbers.indexOf(40));
            Console.WriteLine("Highest number in array : " + numbers.Max()) ;
            numbers.Print();
        }
    }
}