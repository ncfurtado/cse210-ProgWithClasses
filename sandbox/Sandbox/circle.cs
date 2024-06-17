class Circle
{
    private double _radius;

    public Circle(double radius = 0.0)
    {
        _radius = radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
    public double GetDiameter()
    {
        return _radius * 2;
    }
    public double GetCircumference()
    {
        return 2 * _radius * Math.PI;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
}