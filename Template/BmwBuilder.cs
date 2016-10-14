using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class BmwBuilder : CarBuilder
    {
        protected override void BuildSkeleton()
        {
            Console.WriteLine("Build BMW Skeleton");
        }

        protected override void InstallDoor()
        {
            Console.WriteLine("Install doors to BMW");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Install Engine to BMW");
        }

        protected override void SprayPaint()
        {
            Console.WriteLine("Painting BMW car");
        }
    }
}
