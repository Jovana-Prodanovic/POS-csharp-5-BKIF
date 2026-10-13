using Starship_Mini.Models;

// Starship starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1));
BaseShip starship1 = new Starship("Bounty", 8, new DateOnly(2026, 1, 1))
{
    IsBattleShip = true
};

// Object Initializer Syntax
Starship starship2 = new Starship()
{
    Name = "Bounty",
    CrewMembers = 9,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  true,
};

// Object Initializer Syntax
Starship starship3 = new Starship()
{
    Name = "Bounty",
    CrewMembers = 8,
    BuildAt = new DateOnly(2026, 1, 1),
    IsBattleShip =  false,
};

Console.WriteLine(starship2 == starship3); // dasselbe
Console.WriteLine(starship2.Equals(starship3)); // das Gleiche

var mothership = new MotherShip();
// mothership._baseShips.Add(starship1);
// mothership._baseShips.Clear(); 

DateOnly today = DateOnly.FromDateTime(DateTime.UtcNow);

//erste ship//
starship1.BuildAt = today.AddYears(-2);

//zweite Ship//
starship2.Name = "Voyager";
starship2.CrewMembers = 10;
starship2.BuildAt = today.AddYears(-1);

//drite ship//
starship3.Name = "Orion";
starship3.CrewMembers = 1;
starship3.BuildAt = today.AddYears(-3);

// Ship andocken//
mothership.Dock((starship1));
mothership.Dock(starship2);
mothership.Dock(starship3);

Console.WriteLine(("\nAngedockte Ship:"));

foreach (BaseShip ship in mothership.BaseShips)
{
    Console.WriteLine((ship));
}
// Ex 6: Captain only//

Console.WriteLine($"\nEx 6 -Nur Kapitän : {mothership.CountCaptainOnly()}"
);
// EX 7: Any full ship//
Console.WriteLine(
    $"Ex 7 - Mindestens ein volles Schiff: {mothership.AnyShipFull()}"
);

// Ex 8: Minimum crew//
Console.WriteLine( $"Ex 8 -Alle haben mindrstens 1: {mothership.AllHaveMinCrew(1)}"
    );
Console.WriteLine($" Ex 8 -Alle haben mindestens 2: { mothership.AllHaveMinCrew(2)
}");

// Ex 9:Smallest crew//

Console.WriteLine($"Ex 9 - Kleinste Besatzung: {mothership.SmallestCrew()}"
);
// Ex 10 : Largest crew//

Console.WriteLine(
    $"Ex 10 - Größte Besatzung: {mothership.LargestCrew()}"
);

//Ex 11 : Oldest ship //

Console.WriteLine($"Ex 11 - Ältestes Baudatum: " + 
                  $"{mothership.OldestBuildDate():yyyy-MM-dd}"
);

// Ex 12: ship name //

Console.WriteLine("\nEx 12 - Schiffsnamen:");

foreach (string name in mothership.ShipNames())
{
    Console.WriteLine(name);
}
// Ex 13 : Built after //

DateOnly limitDate = today.AddYears(-2);

Console.WriteLine($"\nEx 13 - Gebaut nach {limitDate:yyyy-MM-dd}:"
);
foreach (BaseShip ship in mothership.BuiltAfter(limitDate))
{
    Console.WriteLine(ship.Name);
    
}
// Ex 14 Sorted by name //

Console.WriteLine($"\nEx 13 - Gebaut nach {limitDate:yyyy-MM-dd}:"
);
foreach (BaseShip ship in mothership.SortedByName())
{
    Console.WriteLine(ship.Name);
}
// Ex 15 Is docked // 

Console.WriteLine($"\nEx 15 - Bounty ist angedockt: {mothership.IsDocked("Bounty")}"
);

Console.WriteLine( $"Ex 15 - Titan ist angedockt: {mothership.IsDocked("Titan")}"
);


