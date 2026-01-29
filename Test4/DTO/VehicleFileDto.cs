class VehicleFileDto
{
    public string Type { get; set; } = "";

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string PlateNumber { get; set; } = "";
    public string Brand { get; set; } = "";
    public bool IsSecondHand { get; set; }
    public double Weight { get; set; }

    // twoWheels
    public bool? IsElectric { get; set; }
    public bool? IsManualGear { get; set; }

    // fourWheels
    public string? CarType { get; set; }
}
