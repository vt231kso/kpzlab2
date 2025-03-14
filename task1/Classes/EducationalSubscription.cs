using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Interfaces;

namespace task1.Classes
{

  public class EducationalSubscription : ISubscription
  {
    public string Name { get; } = "Освітня підписка";
    public double MonthlyFee { get; } = 5.99;
    public int MinPeriod { get; } = 6;
    public List<string> Channels { get; } = new() { "Educational TV", "Discovery", "National Geographic" };
    public List<string> Features { get; } = new() { "Доступ до лекцій", "Без реклами" };

    public void ShowDetails()
    {
      Console.WriteLine($"{Name} - ${MonthlyFee}/міс, Мін. період: {MinPeriod} міс.");
      Console.WriteLine($"Канали: {string.Join(", ", Channels)}");
      Console.WriteLine($"Можливості: {string.Join(", ", Features)}\n");
    }
  }
}
