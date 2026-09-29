
public class Circle : Shape
{
    private double radius;

    public Circle(string color,Location c,double radius) : base(color,c)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return 3.14 * radius * radius;
    }
    public override double Perimetr()
    {
        return 2 * 3.14 * radius;
    }
    public override string ToString()
    {
        return "Circle";
    }
}