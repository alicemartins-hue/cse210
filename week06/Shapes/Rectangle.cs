

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public double SetLength(double length)
    {
        _length = length;
        return _length;
    }

    public double SetWidth(double width)
    {
        _width = width;
        return _width;
    }
    
    public override double GetArea()
    {
        return _length * _width;
    }
}