using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtask5
{
  public class Enemy : Hero
  {
    public List<string> EvilDeeds { get; }

    public Enemy(string name, int height, string build, string hairColor, string eyeColor, string clothing, List<string> inventory, List<string> evilDeeds)
        : base(name, height, build, hairColor, eyeColor, clothing, inventory)
    {
      EvilDeeds = evilDeeds;
    }

    public override string ToString()
    {
      return base.ToString() + $", Злі вчинки: [{string.Join(", ", EvilDeeds)}]";
    }
  }
}
