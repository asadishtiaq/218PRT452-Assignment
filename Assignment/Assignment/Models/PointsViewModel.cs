using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class PointsViewModel
    {
        [Required]
        [RegularExpression(@"(\d{2}.\d*,*\d{2}.\d*)")]
        public string FirstPoint { get; set; }

        [Required]
        [RegularExpression(@"(\d{2}.\d*,*\d{2}.\d*)")]
        public string SecondPoint { get; set; }

        public Vector2 Point1 { get { return string.IsNullOrEmpty(FirstPoint) ? new Vector2() :new Vector2(float.Parse(FirstPoint.Split(',')[0]), float.Parse(FirstPoint.Split(',')[1])); } }

        public Vector2 Point2 { get { return string.IsNullOrEmpty(SecondPoint) ? new Vector2() : new Vector2(float.Parse(SecondPoint.Split(',')[0]), float.Parse(SecondPoint.Split(',')[1])); } }

        public double Gradient { get; set; }
        public double Distance { get; set; }
        public double Equation { get; set; }
    }
}
