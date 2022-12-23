using System;
using System.Collections.Generic;
using System.Text;

namespace LabTasksForClass
{
    internal class ProgrammingGroup : Group
    {
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }

            set
            {
                if (value>=10 && value<=18)
                {
                    _studentLimit = value;
                }
            }
        }

    }
}
