namespace Test1;

internal class Fresher : User
{
    public int Experience { get; set; }
    public string programLanguage { get; set; }

    public Fresher() : base()
    {
        RoleSalaryIndex = 1.5;
        Experience = 0;
        programLanguage = "";
    }

    public Fresher(string name, int age, string address, int gender, int experience, string programLanguage)
        : base(name, age, address, gender, 1.5)
    {
        this.Experience = experience;
        this.programLanguage = programLanguage;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Experience (months): ");
        Experience = Convert.ToInt32(Console.ReadLine());

        Console.Write("Program Language: ");
        programLanguage = Console.ReadLine();
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Experience: {Experience} months, Program Language: {programLanguage}");
        Console.WriteLine($"Salary: {Salary()}");
    }

    public override double Salary()
    {
        return this.Experience * 400000 + (400000 * this.RoleSalaryIndex);
    }
}
