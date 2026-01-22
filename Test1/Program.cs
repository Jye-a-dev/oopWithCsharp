using System;
using System.Collections.Generic;

namespace Test1;

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();
        int option;

        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Add Intern");
            Console.WriteLine("2. Add Fresher");
            Console.WriteLine("3. Add Senior");
            Console.WriteLine("4. Display All Users");
            Console.WriteLine("5. User with Highest Salary");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Intern intern = new Intern();
                    intern.Input();
                    users.Add(intern);
                    break;

                case 2:
                    Fresher fresher = new Fresher();
                    fresher.Input();
                    users.Add(fresher);
                    break;

                case 3:
                    Senior senior = new Senior();
                    senior.Input();
                    users.Add(senior);
                    break;

                case 4:
                    foreach (var user in users)
                    {
                        user.Output();
                    }
                    break;

                case 5:
                    if (users.Count > 0)
                    {
                        User max = users[0];
                        foreach (var user in users)
                        {
                            if (user.Salary() > max.Salary())
                            {
                                max = user;
                            }
                        }
                        Console.WriteLine("User with the highest salary:");
                        max.Output();
                    }
                    else
                    {
                        Console.WriteLine("The list is empty!");
                    }
                    break;
            }

        } while (option != 0);
    }
}
