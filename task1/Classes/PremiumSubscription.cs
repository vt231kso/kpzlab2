using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Interfaces;

namespace task1.Classes
{
  public class PremiumSubscription : ISubscription
  {
    public string Name { get; } = "Преміум підписка";
    public double MonthlyFee { get; } = 19.99;
    public int MinPeriod { get; } = 1;
    public List<string> Channels { get; } = new() { "HBO", "Netflix", "Disney+" };
    public List<string> Features { get; } = new() { "4K якість", "Без реклами", "Доступ до ексклюзивного контенту" };

    public void ShowDetails()
    {
      Console.WriteLine($"{Name} - ${MonthlyFee}/міс, Мін. період: {MinPeriod} міс.");
      Console.WriteLine($"Канали: {string.Join(", ", Channels)}");
      Console.WriteLine($"Можливості: {string.Join(", ", Features)}\n");
    }
  }
}
