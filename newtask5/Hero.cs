using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtask5
{
  public class Hero
  {
    public string Name { get; }
    public int Height { get; }
    public string Build { get; }
    public string HairColor { get; }
    public string EyeColor { get; }
    public string Clothing { get; }
    public List<string> Inventory { get; }

    public Hero(string name, int height, string build, string hairColor, string eyeColor, string clothing, List<string> inventory)
    {
      Name = name;
      Height = height;
      Build = build;
      HairColor = hairColor;
      EyeColor = eyeColor;
      Clothing = clothing;
      Inventory = inventory;
    }

    public override string ToString()
    {
      return $"Герой {Name}, Зріст: {Height}, Статура: {Build}, Волосся: {HairColor}, Очі: {EyeColor}, Одяг: {Clothing}, Інвентар: [{string.Join(", ", Inventory)}]";
    }
  }
}
