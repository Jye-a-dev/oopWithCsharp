namespace Test4
{
    class twoWheels : vehicle
    {
        public bool isEletric { get; private set; }
        public bool isManualGear { get; private set; }

        public twoWheels(
            int id, string name, string plate, string brand,
            bool is2nd, double weight, bool isElec, bool isManGear
        )
        : base(id, name, plate, brand, is2nd, weight)
        {
            isEletric = isElec;
            isManualGear = isManGear;
        }

        public override string Output()
        {
            return base.Output() +
                   $", Xe số:{isManualGear}, Xe điện:{isEletric}";
        }
    }
}
