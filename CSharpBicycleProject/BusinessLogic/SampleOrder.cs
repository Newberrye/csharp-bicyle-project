namespace CSharpBicycleProject;

/*
 * Sample order will be based on purchasing 1 bicycle.
 * We can improve this by handling more than 1 bicycle.
 * This handling has to do with the custom options and how they tie in the
 * bicycle. This could be a simple fix like a property of a custom option list.
 */
internal class SampleOrder
{

    private List<IBicycle> BikeOrder;
    private List<IBikeOptions> BikeOptions;
    private SampleInventory inventory;
    private IBicycle BikeChoice;

    public SampleOrder()
    {
        BikeOrder = new List<IBicycle>();
        BikeOptions = new List<IBikeOptions>();
        inventory = new SampleInventory();
    }

    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome to ACME Bicycle Company");
        Console.WriteLine("Your one stop shop for Road and Mountain Bikes!");
        BuyBike();

    }

    private void BuyBike()
    {
        Console.WriteLine("Choose your bike that you want to purchase: ");
        Console.WriteLine("Your Options are:\n" +
            "c - Cross Country\n" +
            "d - Downhill\n" +
            "t - Touring\n" +
            "v - Vintage");
        Console.Write("Enter letter of choice here: ");

        string type = Console.ReadLine();
        // validate type
        ValidateType(type.ToLower());
        // custom options
        CustomOptions();
        // add custom options to bike
        // add to order
        BikeOrder.Add(BikeChoice);
        // send order to receipt
        new SampleReceipt(BikeOrder, BikeOptions);
    }

    private void CustomOptions()
    {
        Console.WriteLine("We offer varius custom options for your bike.");
        Console.WriteLine("What upgrades would you like?");
        Console.WriteLine("ls - Leather Seat\n" +
            "lg - Leather Grips\n" +
            "gf - Golden Frame\n" +
            "wt - White Tires\n" +
            "n - none");
        Console.Write("Please enter your choice here: ");
        string option = Console.ReadLine();
        // validate options
        ValidateOptions(option.ToLower());
 
    }

    private void ValidateOptions(string options)
    {
        switch(options)
        {
            case ("ls"):
                BikeOptions.Add(new LeatherSeat());
                break;
            case ("lg"):
                BikeOptions.Add(new LeatherGrips());
                break;
            case ("gf"):
                BikeOptions.Add(new GoldenFrame());
                break;
            case ("wt"):
                BikeOptions.Add(new WhiteTires());
                break;
            case ("n"):
                break;
            default:
                Console.WriteLine("Please enter a valid option option.");
                Console.WriteLine();
                CustomOptions();
                break;
        }
    }

    private void ValidateType(string type)
    {
        switch(type)
        {
            case "c":
                BikeChoice = inventory.CrossCountryList.ElementAt(0);
                inventory.CrossCountryList.RemoveAt(0);
                break;
            case "d":
                BikeChoice = inventory.DownhillList.ElementAt(0);
                inventory.DownhillList.RemoveAt(0);
                break;
            case "t":
                BikeChoice = inventory.TouringList.ElementAt(0);
                inventory.TouringList.RemoveAt(0);
                break;
            case "v":
                BikeChoice = inventory.VintageList.ElementAt(0);
                inventory.VintageList.RemoveAt(0);
                break;
            default:
                Console.WriteLine("You have entered an incorrect value, please try again.");
                Console.WriteLine();
                BuyBike();
                break;
        }
    }

} // end class
