/* 
 * To Do:
 *  1. Create a Fork of this repo available at: ???
 *  2. Share your repo with your Tutor and at least 1 other person in your class.
 *  3. 
 */

using GithubIntroduction;

public class Circle : Regular2DShape
{
    public Circle(double length) : base(length)
    {
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Length / 2, 2);
    }
}