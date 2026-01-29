using System;
using System.Collections.Generic;
using System.Linq;

namespace Test4
{
    class vehicleService
    {
        private readonly List<vehicle> vehicles;
        private readonly FileService fileService = new FileService();

        public vehicleService()
        {
            vehicles = fileService.Load();
        }

        public void Add(vehicle v)
        {
            if (vehicles.Any(x => x.Id == v.Id))
                throw new ArgumentException("ID đã tồn tại");

            vehicles.Add(v);
            fileService.Save(vehicles);
        }

        public bool Remove(int id)
        {
            var v = vehicles.FirstOrDefault(x => x.Id == id);
            if (v == null) return false;

            vehicles.Remove(v);
            fileService.Save(vehicles);
            return true;
        }

        public List<vehicle> GetAll() => new(vehicles);

        public List<twoWheels> GetTwoWheels() =>
            vehicles.OfType<twoWheels>().ToList();

        public List<fourWheels> GetFourWheels() =>
            vehicles.OfType<fourWheels>().ToList();
    }
}
