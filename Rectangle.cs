public class Rectangle : Shape
{
    private double length;
    private double width;
    public Rectangle(string color,Location c,double length,double width) : base(color,c)
    {
        this.width = width;
        this.length = length;
    }
    public override double Area()
    {
        return length * width;
    }
    public override double Perimetr()
    {
        return 2 * (length + width);
    }
    public override string ToString()
    {
        return "Rectangle";
    }
}