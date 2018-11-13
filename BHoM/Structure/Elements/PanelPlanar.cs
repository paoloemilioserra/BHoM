﻿using System.Collections.Generic;
using BH.oM.Structure.Properties;
using BH.oM.Base;

namespace BH.oM.Structure.Elements
{
    /// <summary>
    /// BH.oM panel class - a planar surface object with a list of 'edges' (curves with properties) for both external and internal edges (openings)
    /// </summary>
    public class PanelPlanar : Base.BHoMObject, IAreaElement, IElement2D
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public List<Edge> ExternalEdges { get; set; } = new List<Edge>();

        public List<Opening> Openings { get; set; } = new List<Opening>();

        public IProperty2D Property { get; set; } = new ConstantThickness();      


        /***************************************************/ 
    }
}
       