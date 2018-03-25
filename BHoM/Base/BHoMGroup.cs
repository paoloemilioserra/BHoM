﻿using System.Collections.Generic;

namespace BH.oM.Base
{
    public class BHoMGroup<T> : BHoMObject where T:IBHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public List<T> Elements { get; set; } = new List<T>();


        /***************************************************/
    }
}
