using task4;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Virus parent = new Virus("Corona", 1.2, 5, "RNA Virus");
Virus child1 = new Virus("Delta", 0.9, 2, "Mutation");
Virus child2 = new Virus("Omicron", 0.8, 1, "Mutation");
Virus grandChild = new Virus("Omicron-BA2", 0.7, 1, "Subvariant");


child2.AddChild(grandChild);
parent.AddChild(child1);
parent.AddChild(child2);

Console.WriteLine("Оригінальне сімейство вірусів:");
parent.Print();


Virus clonedParent = (Virus)parent.Clone();

Console.WriteLine("\nКлоноване сімейство вірусів:");
clonedParent.Print();
