using Test3;

namespace Test3
{
    class UserService
    {
        private readonly List<User> users;
        private readonly FileService fileService = new FileService();

        public UserService()
        {
            users = fileService.Load();
        }

        public void Add(User user)
        {
            if (users.Any(u => u.Id == user.Id))
                throw new ArgumentException("ID đã tồn tại");

            users.Add(user);
            fileService.Save(users);
        }

        public bool Remove(string id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return false;

            users.Remove(user);
            fileService.Save(users);
            return true;
        }

        public List<User> GetAll() => new(users);

        public List<Student> GetStudents() =>
            users.OfType<Student>().ToList();

        public List<Teacher> GetTeachers() =>
            users.OfType<Teacher>().ToList();
    }
}
