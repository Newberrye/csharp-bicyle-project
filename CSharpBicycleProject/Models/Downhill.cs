namespace CSharpBicycleProject;

internal class Downhill : MountainBike
{
    public override BikeColor FrameColor { get; set; } = BikeColor.Black;
    public override decimal Price { get; } = 699.99M;
    public override int StartNumber { get; } = 852_654;
    public override string Model { get; } = "DB505";

    public Downhill(IWheel wheel)
     : base(wheel) { }
}
