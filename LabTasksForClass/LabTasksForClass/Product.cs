using System;
using System.Collections.Generic;
using System.Text;

namespace LabTasksForClass
{
    internal class Product
    {
        public string Name;
        private double _price;

        public double Price 
        {
            get => _price; 
            
            set
            {
                if(value>=0 && value<=10000)
                {
                    _price= value;
                }
            }
        }
    }
}
