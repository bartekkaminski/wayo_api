using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wayo_API.Models
{
    public class UpdateWayoPositionModel
    {
        public double[] CurrentPosition { get; set; }

        public double RemainningDuration { get; set; }
        public double RemainningDistance { get; set; }

        public UpdateWayoPositionModel()
        {
            CurrentPosition = new double[2];
        }
    }
}
