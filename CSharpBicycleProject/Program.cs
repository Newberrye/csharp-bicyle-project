using CSharpBicycleProject;

//TestingModel();
//SerialGeneratorTester();
//TestBikeOptions();
TestProgram();

void TestProgram()
{
    SampleOrder sampleOrder = new SampleOrder();
    sampleOrder.WelcomeMessage();
}

// Testing BikeOptions
void TestBikeOptions()
{
    Touring touring = new Touring(new NormalWheel());
    LeatherGrips grips = new LeatherGrips();
    decimal total = touring.Price + grips.OptionPrice;
    Console.WriteLine($"Bike price is {touring.Price:C} and leather grips are {grips.OptionPrice:C}.");
    Console.WriteLine($"The total price is {total:C}.");
}

// Testing Serial Number Generator
void SerialGeneratorTester()
{
    Downhill downhill = new Downhill(new WideWheel());
    SerialNumberGenerator generator = SerialNumberGenerator.Instance;
    generator.SetModelAndStart(downhill.Model, downhill.StartNumber);
    downhill.SerialNumber = generator.GetNextSerial();
    Console.WriteLine($"First Serial {downhill.SerialNumber}");
    Console.WriteLine($"Next serial {generator.GetNextSerial()}");
    Console.WriteLine($"Next serial {generator.GetNextSerial()}");
    Console.WriteLine($"Next serial {generator.GetNextSerial()}");
    Console.WriteLine($"Next serial {generator.GetNextSerial()}");

    Console.WriteLine();
    SerialNumberGenerator generator2 = SerialNumberGenerator.Instance;
    generator2.SetModelAndStart(downhill.Model, generator.RecentNumber);
    Console.WriteLine($"Next generator2 Serial {generator2.GetNextSerial()}");
    Console.WriteLine($"Next generator2 Serial {generator2.GetNextSerial()}");
}

// Testing Base Model
void TestingModel()
{
    Vintage myBike = new Vintage(new NormalWheel());
    Console.WriteLine(myBike.Wheel.IsWide);
    Console.WriteLine(myBike.Model);
    Console.WriteLine(myBike.StartNumber);
    Console.WriteLine(myBike.FrameColor);
    myBike.Paint(BikeColor.Green);
    Console.WriteLine(myBike.FrameColor);
}
