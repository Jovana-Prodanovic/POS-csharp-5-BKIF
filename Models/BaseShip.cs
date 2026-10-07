namespace Startship_Mini.Models;

public abstract class BaseShip
{
   private int _crewMembers;


   public int CrewMembers
   {
      get
      {
         return _crewMembers;
      }
      set
      {
         ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, nameof(CrewMembers));
         
         ArgumentOutOfRangeException.ThrowIfGreaterThan(value ,10,nameof(CrewMembers));

         _crewMembers = value;
      } 
   }

   public BaseShip(int crewMembers)
   {
      CrewMembers = crewMembers;
   }

   public BaseShip() : this(1)
   {
      
   }
}