public class Shape
{
    private string color;
    private Location c;
    public Shape(string color,Location c)
    {
        this.color = color;
        this.c = c;
    }
    public virtual string ToString()
    {
        return "Shape";
    }
    public virtual double Area()
    {
        return 0;
    }
    public virtual double Perimetr()
    {
        return 0;
    }
}