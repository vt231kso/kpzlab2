using newtask5;
using System;
using System.Collections.Generic;


namespace Task5
{
  class Program
  {
    static void Main()
    {
      CharacterDirector director = new CharacterDirector();

      Hero hero = director.CreateHero();
      Console.WriteLine(hero);  

      Enemy enemy = director.CreateEnemy();
      Console.WriteLine(enemy);
    }
  }
}
