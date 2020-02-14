using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightHelper.Data
{
    public class WeightCalculatorService
    {
        public Task<List<Weight>> GetWeights()
        {
            var weights = GetDefaultWeights();

            return Task.FromResult(weights);
        }
        public Task<List<double>> CalculateRequiredWeight(double barWeight, List<Weight> availableWeights, double targetWeight)
        {
            var calculatedWeightPerSide = (targetWeight - barWeight) / 2;
            var remainingWeight = calculatedWeightPerSide;
            var weightsToUse = new List<double>();
            foreach (var weight in availableWeights.OrderByDescending(x => x.Value))
            {
                if (!weight.Available)
                {
                    continue;
                }

                while (remainingWeight >= weight.Value)
                {
                    remainingWeight -= weight.Value;
                    weightsToUse.Add(weight.Value);
                }
            }

            return Task.FromResult(weightsToUse);
        }

        private List<Weight> GetDefaultWeights()
        {
            return new List<Weight>{
                new Weight{
                    Value = 50,
                    Available = true
                },
                new Weight{
                    Value = 25,
                    Available = true
                },
                new Weight{
                    Value = 15,
                    Available = true
                },
                new Weight{
                    Value = 10,
                    Available = true
                },
                new Weight{
                    Value = 5,
                    Available = true
                },
                new Weight{
                    Value = 2.5,
                    Available = true
                },
                new Weight{
                    Value = 1.25,
                    Available = true
                }
            };
        }
    }

}