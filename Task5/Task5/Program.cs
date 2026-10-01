class program
{
    static void Main()
    {
        string BottleA = "Water";
        string BottleB = "Juice";

        Console.WriteLine($"BottleA contains {BottleA}, BottleB contains {BottleB}");

        (BottleA, BottleB) = (BottleB, BottleA);

        Console.WriteLine($"BottleA contains {BottleA}, BottleB contains {BottleB}");
    }
}

