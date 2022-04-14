namespace CSharpBicycleProject;

internal abstract class RoadBike : Bicycle
{
    public override string Style { get; } = "Road Bike";

    protected RoadBike(IWheel wheel)
        : base(wheel) { }
}

