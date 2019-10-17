using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTypeLibrary.Models
{
    public class EmptyPkmnType : PkmnType
    {
        public override string TypeName => "(none)";

        public override string TypeColor => "#FFFFFF";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            return 1.0;
        }
    }
}
