using System.Text.Json;

namespace Test4
{
    class FileService
    {
        private const string FILE_PATH = "vehicles.json";

        public void Save(List<vehicle> vehicles)
        {
            var data = new List<VehicleFileDto>();

            foreach (var v in vehicles)
            {
                if (v is twoWheels tw)
                {
                    data.Add(new VehicleFileDto
                    {
                        Type = "twoWheels",
                        Id = tw.Id,
                        Name = tw.Name,
                        PlateNumber = tw.PlateNumber,
                        Brand = tw.Brand,
                        IsSecondHand = tw.isSecondHand,
                        Weight = tw.Weight,
                        IsElectric = tw.isEletric,
                        IsManualGear = tw.isManualGear
                    });
                }
                else if (v is fourWheels fw)
                {
                    data.Add(new VehicleFileDto
                    {
                        Type = "fourWheels",
                        Id = fw.Id,
                        Name = fw.Name,
                        PlateNumber = fw.PlateNumber,
                        Brand = fw.Brand,
                        IsSecondHand = fw.isSecondHand,
                        Weight = fw.Weight,
                        CarType = fw.Type,
                        IsElectric = fw.isEletric
                    });
                }
            }

            File.WriteAllText(
                FILE_PATH,
                JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                })
            );
        }

        public List<vehicle> Load()
        {
            if (!File.Exists(FILE_PATH))
                return new List<vehicle>();

            var json = File.ReadAllText(FILE_PATH);
            var data = JsonSerializer.Deserialize<List<VehicleFileDto>>(json);

            var vehicles = new List<vehicle>();
            if (data == null) return vehicles;

            foreach (var d in data)
            {
                if (d.Type == "twoWheels")
                {
                    vehicles.Add(new twoWheels(
                        d.Id, d.Name, d.PlateNumber, d.Brand,
                        d.IsSecondHand, d.Weight,
                        d.IsElectric!.Value,
                        d.IsManualGear!.Value
                    ));
                }
                else if (d.Type == "fourWheels")
                {
                    vehicles.Add(new fourWheels(
                        d.Id, d.Name, d.PlateNumber, d.Brand,
                        d.IsSecondHand, d.Weight,
                        d.CarType!,
                        d.IsElectric!.Value
                    ));
                }
            }

            return vehicles;
        }
    }
}
