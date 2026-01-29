using System.Text.Json;

namespace Test3
{
    class FileService
    {
        private const string FILE_PATH = "users.json";

        public void Save(List<User> users)
        {
            var data = new List<UserFileDto>();

            foreach (var u in users)
            {
                if (u is Student s)
                {
                    data.Add(new UserFileDto
                    {
                        Type = "Student",
                        Id = s.Id,
                        Name = s.Name,
                        Age = s.Age,
                        GPA = s.GPA,
                        Grade = s.Grade,
                        Class = s.ClassNumber  
                    });
                }
                else if (u is Teacher t)
                {
                    data.Add(new UserFileDto
                    {
                        Type = "Teacher",
                        Id = t.Id,
                        Name = t.Name,
                        Age = t.Age,
                        Subject = t.Subject,
                        BaseSalary = t.BaseSalary   
                    });
                }
            }

            File.WriteAllText(
                FILE_PATH,
                JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true })
            );
        }

        public List<User> Load()
        {
            if (!File.Exists(FILE_PATH))
                return new List<User>();

            var json = File.ReadAllText(FILE_PATH);
            var data = JsonSerializer.Deserialize<List<UserFileDto>>(json);

            var users = new List<User>();
            if (data == null) return users;

            foreach (var d in data)
            {
                if (d.Type == "Student")
                {
                    users.Add(new Student(
                        d.Id,
                        d.Name,
                        d.Age,                 
                        d.GPA!.Value,
                        d.Grade!.Value,
                        d.Class!.Value
                    ));
                }
                else if (d.Type == "Teacher")
                {
                    users.Add(new Teacher(
                        d.Id,
                        d.Name,
                        d.Age,
                        d.Subject!,
                        d.BaseSalary!.Value
                    ));
                }
            }

            return users;
        }
    }
}
