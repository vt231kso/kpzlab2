using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
  public class Virus : ICloneable
  {
    public string Name { get; set; }      
    public double Weight { get; set; }    
    public int Age { get; set; }          
    public string Type { get; set; }      
    public List<Virus> Children { get; set; } = new List<Virus>(); 
    
    public Virus(string name, double weight, int age, string type)
    {
      Name = name;
      Weight = weight;
      Age = age;
      Type = type;
    }

    
    public void AddChild(Virus child)
    {
      Children.Add(child);
    }

    
    public object Clone()
    {
     
      Virus clonedVirus = new Virus(Name, Weight, Age, Type);

      
      foreach (var child in Children)
      {
        clonedVirus.Children.Add((Virus)child.Clone()); 
      }

      return clonedVirus;
    }


    public void Print(int level = 0)
    {
      Console.WriteLine($"{new string('-', level * 2)}> {Name} ({Type}) - Вага: {Weight}, Вік: {Age}");
      foreach (var child in Children)
      {
        child.Print(level + 1);
      }
    }
  }
}
