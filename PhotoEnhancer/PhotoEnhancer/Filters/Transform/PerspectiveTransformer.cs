using System;
using System.Drawing;

namespace PhotoEnhancer
{
    public class PerspectiveTransformer : ITransformer<PerspectiveParameters>
    {
        public Size ResultSize { get; private set; }

        Size originalSize;
        double N;

        public void Initialize(Size size, PerspectiveParameters parameters)
        {
            originalSize = size;
            N = parameters.N;
            ResultSize = originalSize;
        }

        public Point? MapPoint(Point point)
        {
            point = new Point(point.X - ResultSize.Width / 2, point.Y);

            var percent = N / 100;
            var y = (int)(point.Y);
            percent += (1 - percent) * (point.Y / (double)ResultSize.Height);
            var x = ResultSize.Width / 2 + (int)(point.X / percent);

            if (x < 0 || x > originalSize.Width - 1)
                return null;

            return new Point(x, y);
        }
    }
}
