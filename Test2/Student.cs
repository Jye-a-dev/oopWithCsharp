namespace Test2;

class Student
{
    public int Id { get; set; }
    public String Name { get; set; }
    public int Age { get; set; }
    public Double GPA { get; set; }

    public Student()
    {
        this.Id = 0;
        this.Name = "";
        this.Age = 0;
        this.GPA = 0;
    }

    public Student(int id, String name, int age, Double GPA)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.GPA = GPA;
    }

    public void Input()
    {
        Console.WriteLine("Nhập mã số sinh viên: ");
        this.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập họ tên: ");
        this.Name = Console.ReadLine() ?? "";
        Console.WriteLine("Tuổi: ");
        this.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("GPA: ");
        this.GPA = Convert.ToDouble(Console.ReadLine());
    }
    public string CheckStudent()
    {
        if (GPA <= 35) return "Kém";
        if (GPA <= 50) return "Trung bình";
        if (GPA <= 70) return "Khá";
        if (GPA <= 85) return "Giỏi";
        return "Xuất sắc";
    }
    public void DisplayMethod()
    {
        Console.WriteLine($"Id: {this.Id}, Tên: {this.Name}, Tuổi {this.Age}, GPA: {this.GPA}, Loại: {CheckStudent()}");
    }
}