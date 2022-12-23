using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LabTasksForClass
{
    internal class Bycle:Vehicle
    {
        public Bycle(string brand,string color,int millage):base(color,brand,millage)
        {

        }

        public void Drive(int km)
        {
            Millage += km;
        }

        public string ShowInfo()
        {
            return $"Brand-{Brand}, Color-{Color},Millage-{Millage}";
        }
    }
}
