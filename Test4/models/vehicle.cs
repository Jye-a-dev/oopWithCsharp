namespace Test4
{
    abstract class vehicle
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string PlateNumber { get; private set; }
        public string Brand { get; private set; }
        public bool isSecondHand { get; private set; }
        public double Weight { get; private set; }

        protected vehicle(int id, string name, string plate, string brand, bool is2nd, double weight)
        {
            if (id <= 0)
                throw new ArgumentException("Id không hợp lệ");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên xe không được rỗng");

            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Hãng xe không được rỗng");

            if (string.IsNullOrWhiteSpace(plate))
                throw new ArgumentException("Biển xe không được rỗng");

            if (double.IsNaN(weight) || weight <= 0)
                throw new ArgumentException("Cân nặng không hợp lệ");

            Id = id;
            Name = name.Trim();
            PlateNumber = plate.Trim();
            Brand = brand.Trim();
            isSecondHand = is2nd;
            Weight = weight;
        }

        public virtual string Output()
        {
            return $"Id:{Id}, Tên:{Name}, Biển:{PlateNumber}, Hãng:{Brand}, Xe cũ:{isSecondHand}, Nặng:{Weight}";
        }
    }
}
