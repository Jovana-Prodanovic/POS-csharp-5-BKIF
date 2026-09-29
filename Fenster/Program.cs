using FensterModel;

var f = new Fenster(
    "Wohnzimmer",
    120.0,
    150.0);

f.Rename("Küche");

var rf = new RolladenFenster(
    "Schlafzimmer",
    100.0,
    140.0,
    true);

rf.SetRolladenVorhanden(false);

Console.WriteLine(f);
Console.WriteLine(rf);