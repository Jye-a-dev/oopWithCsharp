namespace Test1;

internal class Intern : User
{
    public int Internship { get; set; }
    public string Skills { get; set; }

    public Intern() : base()
    {
        RoleSalaryIndex = 1.2;
        Internship = 0;
        Skills = "";
    }

    public Intern(string name, int age, string address, int gender, int internship, string skills): 
    base(name, age, address, gender, 1.2)
    {
        this.Internship = internship;
        this.Skills = skills;
    }
   public override void Input()
    {
       
        base.Input();

        Console.Write("Internship duration (months): ");
        Internship = Convert.ToInt32(Console.ReadLine());

        Console.Write("Skills: ");
        Skills = Console.ReadLine();
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Internship: {Internship} months, Skills: {Skills}");
        Console.WriteLine($"Salary: {Salary()}");
    }
    public override Double Salary()
    {
        return this.Internship * 300000 + (300000 * this.RoleSalaryIndex) ;
    }
}
