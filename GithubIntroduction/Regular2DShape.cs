using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubIntroduction
{
    public abstract class Regular2DShape
    {
        private double _length;     // Length of a side

        /// <summary>
        /// Length of a side
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        /// <summary>
        /// A regular 2D shape where all sides are the same length.
        /// </summary>
        /// <param name="length">Length of a side</param>
        public Regular2DShape(double length)
        {
            _length = length;
        }

        public abstract double GetArea();
    }
}