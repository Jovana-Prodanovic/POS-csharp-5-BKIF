using Startship_Mini.Models;

BaseShip startship1 = new Startship(
    "Bounty",
    8,
    new DateOnly(2026, 1, 1));

Console.WriteLine("Erstes Raumschiff:");
Console.WriteLine(startship1);

Startship startship2 = new Startship()
{
    Name = "Exporer",
    CrewMembers = 5,
    BuildAt = new DateOnly(2026, 2, 1),
    IsBattleShip = true
};

Console.WriteLine();
Console.WriteLine("Zweites Raumschiff:");
Console.WriteLine(startship2);

Console.WriteLine();
Console.WriteLine($"Name vor der Änderung :{startship2.Name}");

startship2.Name = "Explorer II";
startship2.CrewMembers = 7;

Console.WriteLine("Nach der Änderung:");
Console.WriteLine(startship2);

Console.WriteLine();
Console.WriteLine("Validierungstest:");

try
{
    startship2.CrewMembers = 11;

}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine(
        "Ungültiger Wert : CrewMembers muss zwischen 1 und 10 liegen.");
    
}
Console.WriteLine(
    $"CrewMembers nach dem Fehler: {startship2.CrewMembers}");


