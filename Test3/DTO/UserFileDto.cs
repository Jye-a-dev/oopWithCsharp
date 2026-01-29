namespace Test3
{
    class UserFileDto
    {
        public string Type { get; set; } = "";
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public int Age { get; set; }

        // Student
        public double? GPA { get; set; }
        public int? Grade { get; set; }
        public int? Class { get; set; }

        // Teacher
        public string? Subject { get; set; }
        public double? BaseSalary { get; set; }
    }
}
