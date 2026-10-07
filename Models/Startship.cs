namespace Startship_Mini.Models;

public class Startship : BaseShip
{
    private string _name = string.Empty;
    private DateOnly _buildAt;


    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(Name));
            _name = value.Trim();
        }
    }

    public DateOnly BuildAt
    {
        get
        {
            return _buildAt;
        }
        set
        {
            DateOnly today = DateOnly.FromDateTime((DateTime.UtcNow));

            DateOnly minDate = today.AddYears(-10);
            
            ArgumentOutOfRangeException.ThrowIfLessThan(value, minDate, nameof(BuildAt));
            
            ArgumentOutOfRangeException.ThrowIfGreaterThan(value,today , nameof(BuildAt));

            _buildAt = value;
        }
    }

    public bool IsBattleShip { get; set; }

    public Startship(
        string name,
        int crewMembers,
        DateOnly buildAt)
        : base(crewMembers)
    {
        Name = name;
        BuildAt = buildAt;
    }

    public Startship()
        : this(
            "Unbenannt",
            1,
            DateOnly.FromDateTime(DateTime.UtcNow))
    {
        
    }

    public override string ToString()
    {
        return $"Starship: Name='{Name}', " +
               $"CrewMembers={CrewMembers}, " +
               $"BuildAt={BuildAt:yyyy-MM-dd}, " +
               $"IsBattleShip={IsBattleShip}";
    }
}