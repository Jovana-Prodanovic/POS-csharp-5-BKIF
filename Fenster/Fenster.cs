namespace FensterModel;

public class Fenster
{
    public string Bezeichnung { get; private set; }

    public double BreiteCm { get; private set; }

    public double HoeheCm { get; private set; }

    public double FlaecheCm2 => BreiteCm * HoeheCm;

    public Fenster(
        string bezeichnung,
        double breiteCm,
        double hoeheCm)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(bezeichnung);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(breiteCm);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(hoeheCm);

        Bezeichnung = bezeichnung.Trim();
        BreiteCm = breiteCm;
        HoeheCm = hoeheCm;
    }

    public void Rename(string neueBezeichnung)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(neueBezeichnung);

        Bezeichnung = neueBezeichnung.Trim();
    }

    public override string ToString()
    {
        return $"Fenster{{bezeichnung='{Bezeichnung}', " +
               $"breiteCm={BreiteCm}, " +
               $"hoeheCm={HoeheCm}, " +
               $"flaecheCm2={FlaecheCm2}}}";
    }
}
