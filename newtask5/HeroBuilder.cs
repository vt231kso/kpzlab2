using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtask5
{
  public class HeroBuilder : ICharacterBuilder
  {
    protected string _name;
    protected int _height;
    protected string _build;
    protected string _hairColor;
    protected string _eyeColor;
    protected string _clothing;
    protected List<string> _inventory = new List<string>();

    public ICharacterBuilder SetName(string name)
    {
      _name = name;
      return this;
    }

    public ICharacterBuilder SetHeight(int height)
    {
      _height = height;
      return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
      _build = build;
      return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
      _hairColor = hairColor;
      return this;
    }

    public ICharacterBuilder SetEyeColor(string eyeColor)
    {
      _eyeColor = eyeColor;
      return this;
    }

    public ICharacterBuilder SetClothing(string clothing)
    {
      _clothing = clothing;
      return this;
    }

    public ICharacterBuilder AddToInventory(string item)
    {
      _inventory.Add(item);
      return this;
    }

    // Реалізація Build для Hero
    public Hero Build()
    {
      return new Hero(_name, _height, _build, _hairColor, _eyeColor, _clothing, _inventory);
    }
  }
}
