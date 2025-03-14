using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtask5
{
  public class EnemyBuilder : HeroBuilder
  {
    private List<string> _evilDeeds = new List<string>();

    public EnemyBuilder SetEvilDeed(string deed)
    {
      _evilDeeds.Add(deed);
      return this;
    }

    // Реалізація Build для Enemy
    public new Enemy Build()
    {
      return new Enemy(_name, _height, _build, _hairColor, _eyeColor, _clothing, _inventory, _evilDeeds);
    }
  }
}
