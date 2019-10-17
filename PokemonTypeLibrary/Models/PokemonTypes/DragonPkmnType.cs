namespace PokemonTypeLibrary.Models
{
    public class DragonPkmnType : PkmnType
    {
        public override string TypeName => "DRAGON";

        public override string TypeColor => "#7038F8";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is DragonPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is SteelPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is FairyPkmnType)
            {
                output = 0.0;
            }
            else
            {
                output = 1.0;
            }
            return output;
        }
    }
}
