using System;
using System.Collections.Generic;

namespace WeightHelperWeb.Models
{
    public class WeightSelectorViewModel
    {
        public List<Weight> AvailableWeights { get; set; }
        public double BarWeight { get; set; }
        public double TargetWeight { get; set; }
    }
}