using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TireMountLibrary
{
    public class Automobile
    {
        public string CarModel { get; }
        public string CarNumber { get; }

        public Automobile(string carModel, string carNumber)
        {
            CarModel = carModel;
            CarNumber = carNumber;
        }
    }
}
