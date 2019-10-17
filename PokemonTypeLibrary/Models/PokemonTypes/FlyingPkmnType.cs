namespace PokemonTypeLibrary.Models
{
    public class FlyingPkmnType : PkmnType
    {
        public override string TypeName => "FLYING";

        public override string TypeColor => "#A890F0";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FightingPkmnType || pkmnType is BugPkmnType || pkmnType is GrassPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is RockPkmnType || pkmnType is SteelPkmnType || pkmnType is ElectricPkmnType)
            {
                output = 0.5;
            }
            else
            {
                output = 1.0;
            }
            return output;
        }
    }
}
