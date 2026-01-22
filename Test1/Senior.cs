namespace Test1;

internal class Senior : User
{
    public int Experience { get; set; }
    public string Specialization { get; set; }

    public Senior() : base()
    {
        RoleSalaryIndex = 3.0;
        Experience = 0;
        Specialization = "";
    }

    public Senior(string name, int age, string address, int gender, int experience, string specialization)
        : base(name, age, address, gender, 3.0)
    {
        this.Experience = experience;
        this.Specialization = specialization;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Experience (months): ");
        Experience = Convert.ToInt32(Console.ReadLine());

        Console.Write("Specialization: ");
        Specialization = Console.ReadLine();
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Experience: {Experience} months, Specialization: {Specialization}");
        Console.WriteLine($"Salary: {Salary()}");
    }

    public override double Salary()
    {
        return this.Experience * 800000 + (400000 * this.RoleSalaryIndex);
    }
}
