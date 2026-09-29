namespace FensterModel;

public class RolladenFenster : Fenster
{
    public bool RolladenVorhanden { get; private set; }

    public RolladenFenster(
        string bezeichnung,
        double breiteCm,
        double hoeheCm,
        bool rolladenVorhanden)
        : base(bezeichnung, breiteCm, hoeheCm)
    {
        RolladenVorhanden = rolladenVorhanden;
    }

    public void SetRolladenVorhanden(bool rolladenVorhanden)
    {
        RolladenVorhanden = rolladenVorhanden;
    }

    public override string ToString()
    {
        return $"RolladenFenster{{bezeichnung='{Bezeichnung}', " +
               $"flaecheCm2={FlaecheCm2}, " +
               $"rolladenVorhanden={RolladenVorhanden}}}";
    }
}
    

    

