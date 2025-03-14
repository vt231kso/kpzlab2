using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtask5
{
  public class CharacterDirector
  {
    public Hero CreateHero()
    {
      return new HeroBuilder()
          .SetName("Артур Великий")
          .SetHeight(190)
          .SetBuild("Масивний")
          .SetHairColor("Золотистий")
          .SetEyeColor("Зелені")
          .SetClothing("Магічний обладунок")
          .AddToInventory("Світлоносний меч")
          .AddToInventory("Щит Вогняного Блиску")
          .AddToInventory("Плащ невидимості")
          .Build();
    }

    public Enemy CreateEnemy()
    {
      // Використовуємо EnemyBuilder, а не ICharacterBuilder
      EnemyBuilder builder = new EnemyBuilder();  // Оголошуємо EnemyBuilder
      builder.SetEvilDeed("Спалив село")
             .SetEvilDeed("Спалив село")
             .SetEvilDeed("Вкрав магічну сферу")
             .SetName("Темний Чаклун")
             .SetHeight(170)
             .SetBuild("Худорлявий")
             .SetHairColor("Чорний")
             .SetEyeColor("Червоні")
             .SetClothing("Темний плащ")
             .AddToInventory("Чорна паличка")
             .AddToInventory("Книга темної магії");


      return builder.Build();  // Викликаємо Build для створення об'єкта Enemy
    }
  }

}
