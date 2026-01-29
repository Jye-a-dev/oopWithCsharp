using System;

namespace Test4
{
    class Menu
    {
        private readonly vehicleService vehicleService = new vehicleService();

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== VEHICLE MANAGER =====");
                Console.WriteLine("1. Thêm xe");
                Console.WriteLine("2. Xóa xe theo ID");
                Console.WriteLine("3. Hiển thị tất cả xe");
                Console.WriteLine("4. Hiển thị xe 2 bánh");
                Console.WriteLine("5. Hiển thị xe 4 bánh");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddVehicle();
                            break;

                        case "2":
                            RemoveVehicle();
                            break;

                        case "3":
                            ShowAll();
                            break;

                        case "4":
                            ShowTwoWheels();
                            break;

                        case "5":
                            ShowFourWheels();
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        private void AddVehicle()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Tên xe: ");
            string name = Console.ReadLine()!;

            Console.Write("Biển số: ");
            string plate = Console.ReadLine()!;

            Console.Write("Hãng xe: ");
            string brand = Console.ReadLine()!;

            Console.Write("Xe cũ (true/false): ");
            bool is2nd = bool.Parse(Console.ReadLine()!);

            Console.Write("Cân nặng: ");
            double weight = double.Parse(Console.ReadLine()!);

            Console.WriteLine("\nChọn loại xe:");
            Console.WriteLine("1. Xe 2 bánh");
            Console.WriteLine("2. Xe 4 bánh");
            Console.Write("Chọn: ");

            string typeChoice = Console.ReadLine()!;
            vehicle v;

            if (typeChoice == "1")
            {
                Console.Write("Xe điện (true/false): ");
                bool isElec = bool.Parse(Console.ReadLine()!);

                Console.Write("Xe số (true/false): ");
                bool isManual = bool.Parse(Console.ReadLine()!);

                v = new twoWheels(
                    id, name, plate, brand,
                    is2nd, weight,
                    isElec, isManual
                );
            }
            else if (typeChoice == "2")
            {
                Console.Write("Loại xe (Sedan/SUV/...): ");
                string carType = Console.ReadLine()!;

                Console.Write("Xe điện (true/false): ");
                bool isElec = bool.Parse(Console.ReadLine()!);

                v = new fourWheels(
                    id, name, plate, brand,
                    is2nd, weight,
                    carType, isElec
                );
            }
            else
            {
                Console.WriteLine("✘ Loại xe không hợp lệ");
                return;
            }

            vehicleService.Add(v);
            Console.WriteLine("✔ Thêm xe thành công");
        }

        private void RemoveVehicle()
        {
            Console.Write("Nhập ID cần xóa: ");
            int id = int.Parse(Console.ReadLine()!);

            if (vehicleService.Remove(id))
                Console.WriteLine("✔ Xóa thành công");
            else
                Console.WriteLine("✘ Không tìm thấy xe");
        }

        // ================= SHOW =================

        private void ShowAll()
        {
            foreach (var v in vehicleService.GetAll())
            {
                Console.WriteLine(v.Output());
            }
        }

        private void ShowTwoWheels()
        {
            foreach (var v in vehicleService.GetTwoWheels())
            {
                Console.WriteLine(v.Output());
            }
        }

        private void ShowFourWheels()
        {
            foreach (var v in vehicleService.GetFourWheels())
            {
                Console.WriteLine(v.Output());
            }
        }
    }
}
