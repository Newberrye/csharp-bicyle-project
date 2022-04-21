namespace CSharpBicycleProject;

internal interface IBicycle
{
    IWheel Wheel { get;  }
    BikeColor FrameColor { get; set; }
    decimal Price { get; }
    int StartNumber { get; }
    string Model { get; }
    string Style { get; }
    string SerialNumber { get; set;}


    void Paint(BikeColor color);

    // Prepare for sale
    void CleanFrame();
    void AirTires();
    void TestRide();
}
