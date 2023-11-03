
using System.Drawing;

namespace slope.Model
{
    public class Linecalculator : Ipoint
    {
        public string IsOnALine(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Point po1 = new Point()
            {
                x = x1,
                y = y1,
            };
            Point po2 = new Point()
            {
                x = x2,
                y = y2,
            };
            Point po3 = new Point()
            {
                x = x3,
                y = y3,
            };
            double calc1 = (po2.y - po1.y) / (po2.x - po1.x);
            double calc2 = (po3.y - po2.y) / (po3.x - po2.x);
            if (calc1 == calc2)
            {
                string result = "These three dots are on the same line.";

                return result;
            }
            else
            {
                string result = "These Three dots aren't on the same line.";
                return result;
            }
        }
    }
}
