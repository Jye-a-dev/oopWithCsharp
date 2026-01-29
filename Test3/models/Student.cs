namespace Test3
{
    class Student : User
    {
        public int Grade { get; private set; }
        public int ClassNumber { get; private set; }
        public double GPA { get; private set; }

        public Student(string id, string name, int age, double gpa, int grade, int classNumber)
            : base(id, name,age)
        {
            if (grade < 1 || grade > 12)
                throw new ArgumentException("Khối phải nằm trong [1, 12]");

            if (classNumber < 1 || classNumber > 9)
                throw new ArgumentException("Lớp phải nằm trong [1, 9]");

            if (gpa < 0 || gpa > 10)
                throw new ArgumentException("GPA phải nằm trong [0, 10]");

            Grade = grade;
            ClassNumber = classNumber;
            GPA = gpa;
        }

        public void UpdateGPA(double newGpa)
        {
            if (newGpa < 0 || newGpa > 10)
                throw new ArgumentException("GPA phải nằm trong [0, 10]");

            GPA = newGpa;
        }
    }
}
