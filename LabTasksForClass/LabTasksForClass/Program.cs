using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LabTasksForClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product();
            //product.Price = 4500;
            //Console.WriteLine(product.Price);

            //Console.WriteLine("car");
            //Car car = new Car(5, 25, 1, "White", "BMW", 0);
            //car.ShowInfo();
            //car.Drive(6);
            //car.ShowInfo();


            //Console.WriteLine("Bycle");
            //Bycle bycle = new Bycle("Style", "Red", 5);
            //Console.WriteLine(bycle.ShowInfo());
            //bycle.Drive(10);
            //Console.WriteLine(bycle.ShowInfo());




            string option;
            bool check = false;

            Student[] stuArr = new Student[0];
            do
            {
                Console.WriteLine("1.Student yarat");
                Console.WriteLine("2.Butun Studentler");
                Console.WriteLine("3.Qrup Adina gore axtaris");
                Console.WriteLine("0.Cixis");

                option = Console.ReadLine();


                if (option == "1")
                {
                    string name;
                    int point = 0;
                    string groupNo = "";

                    do
                    {
                        Console.WriteLine("Adi daxil edin: ");
                        name = Console.ReadLine();
                        if (!IsFullname(name))
                        {
                            check = true;
                        }
                        else
                        {
                            Console.WriteLine("Avgpoint daxil edin: ");
                            string pointStr = Console.ReadLine();
                            point = int.Parse(pointStr);
                            if (point < 0 || point > 100)
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("GroupNo daxil edin: ");
                                groupNo = Console.ReadLine();
                            }

                        }


                    } while (check);


                    Student student = new Student();
                    student.Fullname = name;
                    student.AvgPoint = point;
                    student.GroupNo = groupNo;

                    Array.Resize(ref stuArr, stuArr.Length + 1);
                    stuArr[stuArr.Length - 1] = student;

                }

                else if (option == "2")
                {
                    for (int i = 0; i < stuArr.Length; i++)
                    {
                        Console.WriteLine(stuArr[i].ShowInfo());
                    }
                }

                else if (option == "3")
                {
                    string search = Console.ReadLine();

                    for (int i = 0; i < stuArr.Length; i++)
                    {
                        if (stuArr[i].GroupNo.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(stuArr[i].ShowInfo());
                        }
                    }

                }

            } while (option != "0");


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
