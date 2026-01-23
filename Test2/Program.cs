using System;

namespace Test2;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        int option;
        do
        {
            Console.WriteLine("====Chọn====");
            Console.WriteLine("1. Nhập");
            Console.WriteLine("2. Xuất");
            Console.WriteLine("3. Học sinh mức trung bình");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("========");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Student student = new Student();
                    student.Input();
                    students.Add(student);
                    break;
                case 2:
                    Console.WriteLine("========");
                    foreach (var i in students)
                    {
                        i.DisplayMethod();
                    }
                    Console.WriteLine("========");
                    break;
                case 3:
                    foreach (var i in students)
                    {
                        if (i.GPA >= 50)
                        {
                            i.DisplayMethod();
                        }
                    }
                    break;
            }
        } while (option != 0);
    }
}