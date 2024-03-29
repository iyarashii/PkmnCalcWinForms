﻿// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnCalcWinForms/blob/master/LICENSE for license details.

namespace PokemonTypeLibrary.Models
{
    public class NormalPkmnType : PkmnType
    {
        public override string TypeName => "NORMAL";

        public override string TypeColor => "#A8A878";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            
            if (pkmnType is RockPkmnType || pkmnType is SteelPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is GhostPkmnType)
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
