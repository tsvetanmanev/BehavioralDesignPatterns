using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmwShop = new BmwBuilder();
            bmwShop.BuildCar();

            Console.WriteLine("----------------------------------");

            var audiShop = new AudiBuilder();
            audiShop.BuildCar();
        }
    }
}
