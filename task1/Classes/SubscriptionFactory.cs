using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Interfaces;

namespace task1.Classes
{
  public abstract class SubscriptionFactory : ISubscriptionFactory
  {
    public ISubscription CreateSubscription(string type)
    {
      return type switch
      {
        "Domestic" => new DomesticSubscription(),
        "Educational" => new EducationalSubscription(),
        "Premium" => new PremiumSubscription(),
        _ => throw new ArgumentException("❌ Невідомий тип підписки"),
      };
    }
  }
}
