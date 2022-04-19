namespace CSharpBicycleProject;

internal class Touring : RoadBike
{
    public override BikeColor FrameColor { get; set; } = BikeColor.Blue;
    public override decimal Price { get; } = 499.99M;
    public override int StartNumber { get; } = 951_357;
    public override string Model { get; } = "TB901";

    public Touring(IWheel wheel)
     : base(wheel) { }
}
