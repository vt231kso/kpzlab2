using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2.Classes
{
  public class Laptop : IDevice
  {
    public string GetName() => "Laptop";
  }
}
