namespace CSharpBicycleProject;

internal abstract class Bicycle : IBicycle
{
    public IWheel Wheel { get; }
    public string SerialNumber { get; set; }
    public abstract BikeColor FrameColor { get; set; }
    public abstract decimal Price { get; }
    public abstract int StartNumber { get; }
    public abstract string Model { get; }
    public abstract string Style { get; }

    public Bicycle(IWheel wheel)
    {
        Wheel = wheel;
    }

    public void Paint(BikeColor color)
    {
        FrameColor = color;
    }

    public override string ToString()
    {
        return $"The {this.GetType().Name} costs {Price:C}.";
    }
}
