using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TireMountLibrary
{
    public class Automobile
    {
        public string CarModel { get; internal set; }
        public string CarNumber { get; internal set; }

        public Automobile() { }

        public Automobile(string carModel, string carNumber)
        {
            CarModel = carModel;
            CarNumber = carNumber;
        }
    }
}
