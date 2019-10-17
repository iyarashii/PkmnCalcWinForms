namespace PokemonTypeLibrary.Models
{
    public class GrassPkmnType : PkmnType
    {
        public override string TypeName => "GRASS";

        public override string TypeColor => "#78C850";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is GroundPkmnType || pkmnType is RockPkmnType || pkmnType is WaterPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is FlyingPkmnType || pkmnType is PoisonPkmnType || pkmnType is BugPkmnType 
                || pkmnType is SteelPkmnType || pkmnType is FirePkmnType || pkmnType is GrassPkmnType || pkmnType is DragonPkmnType)
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
