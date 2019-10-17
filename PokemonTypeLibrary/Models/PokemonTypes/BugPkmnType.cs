namespace PokemonTypeLibrary.Models
{
    public class BugPkmnType : PkmnType
    {
        public override string TypeName => "BUG";

        public override string TypeColor => "#A8B820";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is GrassPkmnType || pkmnType is PsychicPkmnType || pkmnType is DarkPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is FightingPkmnType || pkmnType is FlyingPkmnType || pkmnType is PoisonPkmnType ||
                pkmnType is GhostPkmnType || pkmnType is SteelPkmnType || pkmnType is FirePkmnType || pkmnType is FairyPkmnType)
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
