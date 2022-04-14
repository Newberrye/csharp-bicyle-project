namespace CSharpBicycleProject;

internal interface IBicycle
{
    IWheel Wheel { get;  }
    BikeColor FrameColor { get; set; }
    decimal Price { get; }
    int StartNumber { get; }
    string Model { get; }
    string Style { get; }


    void Paint(BikeColor color);
}
