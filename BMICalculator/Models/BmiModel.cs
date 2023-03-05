using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMICalculator.Models
{

        public class BmiModel
        {
            public decimal Height { get; set; }
            public decimal Weight { get; set; }

            public decimal CalculateBmi()
            {
                return Math.Round(
                  d: Weight / (decimal)Math.Pow((double)(Height / 100m), 2d),
                  decimals: 2,
                  mode: MidpointRounding.AwayFromZero);
            }
        }
    }

