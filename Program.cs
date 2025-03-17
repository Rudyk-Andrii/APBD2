using System;
using System.Collections.Generic;
using APBD3;

//asfsaf
class Program
{
    static void Main()
    {
        ContainerShip ship = new ContainerShip("Titanic", 30, 100, 50000);
        Console.WriteLine(ship);

        Container liquid = new LiquidContainer(5000, true);
        ship.LoadContainer(liquid);

        Console.WriteLine(ship);
        liquid.Load(2000);
        Console.WriteLine(liquid);

        Container refrigerated = new RefrigeratedContainer(3000, "Bananas");
        ship.LoadContainer(refrigerated);
        Console.WriteLine(refrigerated);
    }
}
