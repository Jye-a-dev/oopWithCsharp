namespace Test4
{
    class fourWheels : vehicle
    {
        public string Type { get; private set; }
        public bool isEletric { get; private set; }

        public fourWheels(
            int id, string name, string plate, string brand,
            bool is2nd, double weight, string type, bool isElec
        )
        : base(id, name, plate, brand, is2nd, weight)
        {
            Type = type;
            isEletric = isElec;
        }

        public override string Output()
        {
            return base.Output() +
                   $", Loại:{Type}, Xe điện:{isEletric}";
        }
    }
}
