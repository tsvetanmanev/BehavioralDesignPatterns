using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class CarBuilder
    {
        protected abstract void BuildSkeleton();
        protected abstract void InstallEngine();
        protected abstract void InstallDoor();
        protected abstract void SprayPaint();

        public void BuildCar()
        {
            BuildSkeleton();
            InstallEngine();
            InstallDoor();
            SprayPaint();
        }
    }
}
