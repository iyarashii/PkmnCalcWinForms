namespace PokemonTypeLibrary.Models
{
    public class IcePkmnType : PkmnType
    {
        public override string TypeName => "ICE";

        public override string TypeColor => "#98D8D8";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FlyingPkmnType || pkmnType is GroundPkmnType || pkmnType is GrassPkmnType ||
                pkmnType is DragonPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is SteelPkmnType || pkmnType is FirePkmnType || pkmnType is WaterPkmnType ||
                pkmnType is IcePkmnType)
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
