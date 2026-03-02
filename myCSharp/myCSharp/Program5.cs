struct Point2D
{
    public Point2D(int  x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Point2D() : this(10, 10) { }
    public int x { get; set; }
    public int y { get; set; }
}

class Program
{
    static void Main()
    {
        Point2D a = new Point2D();
        Point2D b = a;
        Console.WriteLine($"b.x: {b.x} b.y: {b.y} | a.x: {a.x} a.y: {a.y}");
        a.x = 122; a.y = 512;
        Console.WriteLine($"b.x: {b.x} b.y: {b.y} | a.x: {a.x} a.y: {a.y}");
    }
}