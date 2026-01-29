using System;

namespace Test3
{
    class Teacher : User
    {
        public string Subject { get; private set; }
        public double BaseSalary { get; private set; }

        public Teacher(string id, string name, int age, string subject, double baseSalary)
            : base(id, name, age)
        {
            Subject = subject;
            BaseSalary = baseSalary;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $" | Subject: {Subject} | Salary: {BaseSalary}";
        }
    }
}
