using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class AudiBuilder : CarBuilder
    {
        protected override void BuildSkeleton()
        {
            Console.WriteLine("Build Audi Skeleton");
        }

        protected override void InstallDoor()
        {
            Console.WriteLine("Install door to Audi");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Install engine to Audi");
        }

        protected override void SprayPaint()
        {
            Console.WriteLine("Painting the Audi");
        }
    }
}
