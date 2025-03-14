using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2.Classes
{
  public class KiaomiFactory : IDeviceFactory
  {
    public IDevice CreateLaptop() => new Laptop();
    public IDevice CreateNetbook() => new Netbook();
    public IDevice CreateEBook() => new EBook();
    public IDevice CreateSmartphone() => new Smartphone();
  }
}
