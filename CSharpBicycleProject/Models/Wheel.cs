namespace CSharpBicycleProject;

internal abstract class Wheel : IWheel
{
    public abstract int WheelSize { get; }
    public abstract bool IsWide { get; }

    public override string ToString()
    {
        return $"The {this.GetType().Name} has a wheel size of {WheelSize} inches.";
    }
}
