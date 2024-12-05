using System;

class Tree : IComparable<Tree>
{
    public string Name { get; set; } // Назва дерева
    public double Price { get; set; } // Ціна дерева

    public Tree(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // Реалізація методу CompareTo для порівняння дерев за ціною
    public int CompareTo(Tree other)
    {
        if (other == null) return 1; // null вважається меншим
        return Price.CompareTo(other.Price); // Порівняння за ціною
    }

    public override string ToString()
    {
        return $"{Name}: {Price:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення масиву дерев
        Tree[] trees = new Tree[]
        {
            new Tree("Дуб", 1500.00),
            new Tree("Сосна", 1000.00),
            new Tree("Береза", 1200.00),
            new Tree("Ялина", 1800.00)
        };

        Console.WriteLine("Дерева до сортування:");
        foreach (var tree in trees)
        {
            Console.WriteLine(tree);
        }

        // Сортування дерев за ціною
        Array.Sort(trees);

        Console.WriteLine("\nДерева після сортування за ціною:");
        foreach (var tree in trees)
        {
            Console.WriteLine(tree);
        }
    }
}
