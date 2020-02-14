using System.ComponentModel.DataAnnotations;

namespace WeightHelper.Data
{
    public class Weight
    {
        [Required]
        public double Value { get; set; }
        public bool Available { get; set; } = true;
    }
}