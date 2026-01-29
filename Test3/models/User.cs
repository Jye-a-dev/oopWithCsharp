using System;

namespace Test3
{
    abstract class User
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        protected User(string id, string name, int age)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id không được rỗng");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name không được rỗng");

            if (age <= 0)
                throw new ArgumentException("Age phải > 0");

            Id = id.Trim();
            Name = name.Trim();
            Age = age;
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] Id: {Id} | Name: {Name} | Age: {Age}";
        }
    }
}
