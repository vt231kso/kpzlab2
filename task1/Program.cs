using task1.Classes;
using task1.Interfaces;
Console.OutputEncoding = System.Text.Encoding.UTF8;

ISubscriptionFactory websiteFactory = new WebSiteFactory();
ISubscriptionFactory mobileFactory = new MobileAppFactory();
ISubscriptionFactory managerFactory = new ManagerCallFactory();

Console.WriteLine("Створення підписок через веб-сайт:");
ISubscription webSubscription = websiteFactory.CreateSubscription("Domestic");
webSubscription.ShowDetails();

Console.WriteLine("Створення підписок через мобільний додаток:");
ISubscription mobileSubscription = mobileFactory.CreateSubscription("Premium");
mobileSubscription.ShowDetails();

Console.WriteLine("Створення підписок через менеджера:");
ISubscription managerSubscription = managerFactory.CreateSubscription("Educational");
managerSubscription.ShowDetails();

Console.ReadLine();
