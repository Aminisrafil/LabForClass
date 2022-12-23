using System;
using System.Collections.Generic;
using System.Text;

namespace LabTasksForClass
{
    internal class Student
    {
        private string _fullname;
        private int _avgPoint;
        public string GroupNo;

        public string Fullname
        {
            get => _fullname;
            set
            {
                if (IsFullname(value))
                {
                    _fullname = value;
                }
            }
        }

        public int AvgPoint
        {
            get => _avgPoint;
            set
            {
                if (value>=0 && value<=100)
                {
                    _avgPoint = value;
                }
            }
        }


        public string ShowInfo()
        {
            return $"FullName: {Fullname}- AvgPoint {AvgPoint}- Group Number {GroupNo}";
        }

        static bool IsCapitalized(string str)
        {
            if (!Char.IsUpper(str[0]))
                return false;

            for (int i = 1; i < str.Length; i++)
            {
                if (!Char.IsLower(str[i]))
                    return false;
            }

            return true;
        }

        static bool IsFullname(string str)
        {
            var words = str.Split(' ');

            if (words.Length != 2)
                return false;

            if (!IsCapitalized(words[0]) || !IsCapitalized(words[1]))
                return false;

            return true;
        }


    }
}
