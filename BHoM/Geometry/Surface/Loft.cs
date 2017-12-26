﻿using System.Collections.Generic;
using System.Linq;

namespace BH.oM.Geometry
{
    public partial class Loft : ISurface
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public List<ICurve> Curves { get; set; } = new List<ICurve>();


        /***************************************************/
    }
}


