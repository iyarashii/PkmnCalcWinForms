namespace PokemonTypeLibrary.Models
{
    // interface of PkmnType Class
    public interface IPkmnType
    {
        string TypeName { get; }
        double DmgMultiplier { get; set; }
        string TypeColor { get; }
        double CalculateDmgMultiplier(IPkmnType defendingPkmnPrimaryType, IPkmnType defendingPkmnSecondaryType);
    }
}
