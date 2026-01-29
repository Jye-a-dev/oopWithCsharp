using System;

namespace Test3
{
    class Menu
    {
        private readonly UserService userService = new UserService();

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== USER MANAGER =====");
                Console.WriteLine("1. Thêm Student");
                Console.WriteLine("2. Thêm Teacher");
                Console.WriteLine("3. Xóa User theo ID");
                Console.WriteLine("4. Hiển thị tất cả User");
                Console.WriteLine("5. Hiển thị Student");
                Console.WriteLine("6. Hiển thị Teacher");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddStudent();
                            break;

                        case "2":
                            AddTeacher();
                            break;

                        case "3":
                            RemoveUser();
                            break;

                        case "4":
                            ShowAll();
                            break;

                        case "5":
                            ShowStudents();
                            break;

                        case "6":
                            ShowTeachers();
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        private void AddStudent()
        {
            Console.Write("Id: ");
            var id = Console.ReadLine()!;

            Console.Write("Name: ");
            var name = Console.ReadLine()!;

            Console.Write("Age: ");
            var age = int.Parse(Console.ReadLine()!);

            Console.Write("GPA: ");
            var gpa = double.Parse(Console.ReadLine()!);

            Console.Write("Grade (1-12): ");
            var grade = int.Parse(Console.ReadLine()!);

            Console.Write("Class (1-9): ");
            var classNumber = int.Parse(Console.ReadLine()!);

            var student = new Student(id, name, age, gpa, grade, classNumber);
            userService.Add(student);

            Console.WriteLine("✔ Thêm Student thành công");
        }


        private void AddTeacher()
        {
            Console.Write("Id: ");
            var id = Console.ReadLine()!;

            Console.Write("Name: ");
            var name = Console.ReadLine()!;

            Console.Write("Age: ");
            var age = int.Parse(Console.ReadLine()!);

            Console.Write("Subject: ");
            var subject = Console.ReadLine()!;

            Console.Write("Base Salary: ");
            var salary = double.Parse(Console.ReadLine()!);


            var teacher = new Teacher(id, name, age,subject, salary);
            userService.Add(teacher);

            Console.WriteLine("✔ Thêm Teacher thành công");
        }

        private void RemoveUser()
        {
            Console.Write("Nhập ID cần xóa: ");
            var id = Console.ReadLine()!;

            if (userService.Remove(id))
                Console.WriteLine("✔ Xóa thành công");
            else
                Console.WriteLine("✘ Không tìm thấy User");
        }

        private void ShowAll()
        {
            foreach (var user in userService.GetAll())
            {
                Console.WriteLine(user);
            }
        }

        private void ShowStudents()
        {
            foreach (var s in userService.GetStudents())
            {
                Console.WriteLine(s);
            }
        }

        private void ShowTeachers()
        {
            foreach (var t in userService.GetTeachers())
            {
                Console.WriteLine(t);
            }
        }
    }
}
