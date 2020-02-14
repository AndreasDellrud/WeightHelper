using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeightHelper.Data
{
    public class WeightSelector
    {
        public List<Weight> AvailableWeights { get; set; }

        [Required]
        public double BarWeight { get; set; }

        [Required]
        public double TargetWeight { get; set; }
    }
}