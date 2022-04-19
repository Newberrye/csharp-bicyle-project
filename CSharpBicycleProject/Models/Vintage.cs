namespace CSharpBicycleProject;

internal class Vintage : RoadBike
{
    public override BikeColor FrameColor { get; set; } = BikeColor.Red;
    public override decimal Price { get; } = 299.99M;
    public override int StartNumber { get; } = 753_159;
    public override string Model { get; } = "VB801";

    public Vintage(IWheel wheel)
     : base(wheel) { }
}
