using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubIntroduction
{
    public class Octagon : Regular2DShape
    {
        public Octagon(double length) : base(length) { }

        public override double GetArea()
        {
            // Area = 2(1 + sqrt(2))n^2
            
            return 2.0 * (1.0 + Math.Sqrt(2)) * Math.Pow(Length, 2.0);
        }
    }
}