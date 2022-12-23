using System;
using System.Collections.Generic;
using System.Text;

namespace LabTasksForClass
{
    internal class DesignGroup:Group
    {
        public int StudentLimit
        { 
            get=> _studentLimit;
            set
            {
                if (value>=5 && value<=15)
                {
                    _studentLimit = value;
                }
            }
        }

    }
}
