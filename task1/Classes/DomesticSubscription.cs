using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Interfaces;

namespace task1.Classes
{
  public class DomesticSubscription : ISubscription
  {
    public string Name { get; } = "Домашня підписка";
    public double MonthlyFee { get; } = 9.99;
    public int MinPeriod { get; } = 3;
    public List<string> Channels { get; } = new() { "National TV", "Local News", "Sports" };
    public List<string> Features { get; } = new() { "HD якість" };

    public void ShowDetails()
    {
      Console.WriteLine($"{Name} - ${MonthlyFee}/міс, Мін. період: {MinPeriod} міс.");
      Console.WriteLine($"Канали: {string.Join(", ", Channels)}");
      Console.WriteLine($"Можливості: {string.Join(", ", Features)}\n");
    }
  }
}
