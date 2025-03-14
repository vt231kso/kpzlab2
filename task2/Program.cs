using task2.Classes;
using task2.Interfaces;

IDeviceFactory iproneFactory = new IProneFactory();
IDeviceFactory kiaomiFactory = new KiaomiFactory();
IDeviceFactory balaxyFactory = new BalaxyFactory();

// Створення девайсів для кожного бренду
List<IDevice> iproneDevices = new List<IDevice>
            {
                iproneFactory.CreateLaptop(),
                iproneFactory.CreateSmartphone(),
                iproneFactory.CreateEBook()
            };

List<IDevice> kiaomiDevices = new List<IDevice>
            {
                kiaomiFactory.CreateLaptop(),
                kiaomiFactory.CreateSmartphone(),
                kiaomiFactory.CreateNetbook()
            };

List<IDevice> balaxyDevices = new List<IDevice>
            {
                balaxyFactory.CreateEBook(),
                balaxyFactory.CreateNetbook(),
                balaxyFactory.CreateSmartphone()
            };

// Виведення результатів
Console.WriteLine("IProne Devices:");
foreach (var device in iproneDevices)
{
  Console.WriteLine(device.GetName());
}

Console.WriteLine("\nKiaomi Devices:");
foreach (var device in kiaomiDevices)
{
  Console.WriteLine(device.GetName());
}

Console.WriteLine("\nBalaxy Devices:");
foreach (var device in balaxyDevices)
{
  Console.WriteLine(device.GetName());
}
