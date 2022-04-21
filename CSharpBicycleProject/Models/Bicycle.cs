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

    // Prepare for sale
    public void AirTires()
    {
        Console.WriteLine("We air our bike tirews to a consistant 32 psi.");
        Console.WriteLine("We test each tire prior to sale for proper air pressure.");
    }
    public void TestRide()
    {
        Console.WriteLine("We test ride our bicycles to ensure a proper ride.");
        Console.WriteLine("We check all connections after our test ride to ensure safety.");
    }
    public void CleanFrame()
    {
        Console.WriteLine("We wash our bike frames with non-abrasive detergent.");
        Console.WriteLine("We rinse and dry our bike frames for prestine shine.");
    }

    public override string ToString()
    {
        return $"The {this.GetType().Name} costs {Price:C}.";
    }
}
