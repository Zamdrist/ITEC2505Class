namespace RectangleApp
{
    public class Rectangle
    {

        public decimal Area { get; private set; }
        public decimal Perimeter { get; private set; }

        public Rectangle(decimal length, decimal width)
        {
            this.Area = length * width;
            this.Perimeter = 2 * (length + width);

        }
    }
}

