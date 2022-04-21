namespace CSharpBicycleProject;

internal class SampleInventory
{
    private SerialNumberGenerator generator;

    public List<Touring> TouringList { get; private set; }
    public List<Vintage> VintageList { get; private set; }
    public List<Downhill> DownhillList { get; private set; }
    public List<CrossCountry> CrossCountryList { get; private set; }

    public SampleInventory()
    {
        generator = SerialNumberGenerator.Instance;

        //Building our bike list
        TouringList = BuildTouringInventory(10);
        VintageList = BuildVintageInventory(10);
        DownhillList = BuildDownhillInventory(10);
        CrossCountryList = BuildCrossCountryInventory(10);
    }

    private List<Touring> BuildTouringInventory(int amount)
    {
        List<Touring> inventory = new List<Touring>();
        Touring touring = new Touring(new NormalWheel());
        generator.SetModelAndStart(touring.Model, touring.StartNumber);

        for(int i = 0; i < amount; i++)
        {
            touring = new Touring(new NormalWheel());
            touring.SerialNumber = generator.GetNextSerial();
            inventory.Add(touring);
        }

        return inventory;
    }
    private List<Vintage> BuildVintageInventory(int amount)
    {
        List<Vintage> inventory = new List<Vintage>();
        Vintage vintage = new Vintage(new NormalWheel());
        generator.SetModelAndStart(vintage.Model, vintage.StartNumber);

        for(int i = 0; i < amount; i++)
        {
            vintage = new Vintage(new NormalWheel());
            vintage.SerialNumber = generator.GetNextSerial();
            inventory.Add(vintage);
        }

        return inventory;
    }
    private List<Downhill> BuildDownhillInventory(int amount)
    {
        List<Downhill> inventory = new List<Downhill>();
        Downhill downhill = new Downhill(new WideWheel());
        generator.SetModelAndStart(downhill.Model, downhill.StartNumber);

        for(int i = 0; i < amount; i++)
        {
            downhill = new Downhill(new WideWheel());
            downhill.SerialNumber = generator.GetNextSerial();
            inventory.Add(downhill);
        }

        return inventory;
    }
    private List<CrossCountry> BuildCrossCountryInventory(int amount)
    {
        List<CrossCountry> inventory = new List<CrossCountry>();
        CrossCountry crossCountry = new CrossCountry(new WideWheel());
        generator.SetModelAndStart(crossCountry.Model, crossCountry.StartNumber);

        for( int i = 0; i < amount; i++)
        {
            crossCountry = new CrossCountry(new WideWheel());
            crossCountry.SerialNumber = generator.GetNextSerial();
            inventory.Add(crossCountry);
        }
        return inventory;
    }
}
