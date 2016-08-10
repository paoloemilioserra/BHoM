﻿using BHoM.Base.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHoM.Structural.Results
{
    public class NodeReaction : Result
    {
        public override string[] ColumnHeaders
        {
            get
            {
                return new string[] { "Id", "Name", "Loadcase", "TimeStep", "FX", "FY", "FZ", "MX", "MY", "MZ" };
            }
        }

        public NodeReaction()
        {
            Data = new object[10];
        }

        public NodeReaction(object[] data) { Data = data; }

        public NodeReaction(int number, int loadcase, int timeStep, double fx, double fy, double fz, double mx, double my, double mz) : this()
        {
            Name = number;
            TimeStep = timeStep;
            Loadcase = loadcase;
            Id = Name + ":" + loadcase + ":" + TimeStep;
            FX = fx;
            FY = fy;
            FZ = fz;
            MX = mx;
            MY = my;
            MZ = mz;
        }

        public double FX
        {
            get
            {
                return (double)Data[4];
            }
            set
            {
                Data[5] = value;
            }
        }

        public double FY
        {
            get
            {
                return (double)Data[5];
            }
            set
            {
                Data[5] = value;
            }
        }

        public double FZ
        {
            get
            {
                return (double)Data[6];
            }
            set
            {
                Data[6] = value;
            }
        }

        public double MX
        {
            get
            {
                return (double)Data[7];
            }
            set
            {
                Data[7] = value;
            }
        }

        public double MY
        {
            get
            {
                return (double)Data[8];
            }
            set
            {
                Data[8] = value;
            }
        }

        public double MZ
        {
            get
            {
                return (double)Data[9];
            }
            set
            {
                Data[9] = value;
            }
        }
    }
}
