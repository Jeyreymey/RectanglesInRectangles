using System;

namespace RectanglesInRectangles
{
    class Rectangle
    {
        public bool FitsInRectangle(Rectangle rectangleToFitIn)
        {
            return
                AreaCondition(rectangleToFitIn)
                && DiameterCondition(rectangleToFitIn)
                && PerimeterCondition(rectangleToFitIn)
                && ThicknessCondition(rectangleToFitIn)
                && WCarversCondition(rectangleToFitIn);
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private readonly int width;
        private readonly int height;

        public int Area
        {
            get { return width * height; }
        }

        public int Diameter
        {
            get { return width * height; }
        }

        public int Perimeter
        {
            get { return width + height; }
        }

        public int ThickistSide
        {
            get { return Math.Min(width, height); }
        }

        public bool AreaCondition(Rectangle rectangle)
        {
            return Area <= rectangle.Area;
        }

        public bool DiameterCondition(Rectangle rectangle)
        {
            return Diameter <= rectangle.Diameter;
        }

        public bool PerimeterCondition(Rectangle rectangle)
        {
            return Perimeter <= rectangle.Perimeter;
        }

        public bool ThicknessCondition(Rectangle rectangle)
        {
            return ThickistSide <= rectangle.ThickistSide;
        }

        public bool WCarversCondition(Rectangle rectangle)
        {
            var hasShorterWidth = width <= rectangle.width;
            var hasShorterHeight = height <= rectangle.height;
            var wCarversFirstConditionWasMet = hasShorterWidth && hasShorterHeight;

            if (wCarversFirstConditionWasMet)
            {
                return true;
            }

            if (JohnEWetzelsEquation(width, height, rectangle.width, rectangle.height))
            {
                return true;
            }

            return false;
        }

        private static bool JohnEWetzelsEquation(int a, int b, int p, int q)
        {
            var condition1 = p > a;
            var condition2 = q <= b;

            var part1 = (a + b) / (p + q);
            var part2 = (a - b) / (p - q);

            var condition3 = Math.Pow(part1, 2) + Math.Pow(part2, 2) >= 2;

            return condition1 && condition2 && condition3;
        }
    }
}