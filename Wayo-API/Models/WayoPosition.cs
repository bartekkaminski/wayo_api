using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wayo_API.Models
{
    public class WayoPosition
    {
        public double[] StartPosition { get; set; }
        public double[] EndPosition { get; set; }
        public List<double[]> ServicePositions { get; set; }
        public double FullDuration { get; set; }
        public double FullDistance { get; set; }

        public double RemainningDuration { get; set; }
        public double RemainningDistance { get; set; }

        public WayoPosition()
        {
            StartPosition = new double[2];
            EndPosition = new double[2];

            ServicePositions = new List<double[]>();
        }
    }
}
