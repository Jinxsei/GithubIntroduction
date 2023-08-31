using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubIntroduction
{
    public class Square : Regular2DShape
    {
        public Square(double length) : base(length)
        {
        }

        public override double GetArea()
        {
            return Math.Pow(Length, 2);
        }
    }
}
