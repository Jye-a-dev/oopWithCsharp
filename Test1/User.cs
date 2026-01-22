namespace Test1;

internal abstract class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public int Gender { get; set; }
    public double RoleSalaryIndex { get; set; }

    public User()
    {
        Name = "";
        Age = 0;
        Address = "";
        Gender = 0;
        RoleSalaryIndex = 1.0;
    }

    public User(string name, int age, string address, int gender, double roleSalaryIndex)
    {
        Name = name;
        Age = age;
        Address = address;
        Gender = gender;
        RoleSalaryIndex = roleSalaryIndex;
    }

    public virtual void Input()
    {
        Console.Write("Name: ");
        Name = Console.ReadLine() ?? "";

        Console.Write("Age: ");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Address: ");
        Address = Console.ReadLine() ?? "";

        Console.Write("Gender (1 = Male, 2 = Female): ");
        Gender = Convert.ToInt32(Console.ReadLine());
    }

    public virtual void Output()
    {
        string genderText = Gender switch
        {
            1 => "Male",
            2 => "Female",
            _ => "Unknown"
        };

        Console.WriteLine("================================");
        Console.WriteLine($"Name            : {Name}");
        Console.WriteLine($"Age             : {Age}");
        Console.WriteLine($"Gender          : {genderText}");
        Console.WriteLine($"Address         : {Address}");
        Console.WriteLine($"Role Index      : {RoleSalaryIndex}");
    }

    public abstract double Salary();
}
