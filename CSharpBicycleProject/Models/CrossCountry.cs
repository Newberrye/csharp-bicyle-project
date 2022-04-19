namespace CSharpBicycleProject;

internal class CrossCountry : MountainBike
{
    public override BikeColor FrameColor { get; set; } = BikeColor.Green;
    public override decimal Price { get; } = 599.99M;
    public override int StartNumber { get; } = 258_456;
    public override string Model { get; } = "MB605";

    public CrossCountry(IWheel wheel)
     : base(wheel) { }
}
