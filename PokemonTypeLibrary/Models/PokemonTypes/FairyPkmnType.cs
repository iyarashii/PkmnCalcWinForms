namespace PokemonTypeLibrary.Models
{
    public class FairyPkmnType : PkmnType
    {
        public override string TypeName => "FAIRY";

        public override string TypeColor => "#FF65D5";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FightingPkmnType || pkmnType is DragonPkmnType || pkmnType is DarkPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is PoisonPkmnType || pkmnType is SteelPkmnType || pkmnType is FirePkmnType)
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
