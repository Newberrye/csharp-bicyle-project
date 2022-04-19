namespace CSharpBicycleProject;

internal class GoldenFrame : IBikeOptions
{
    public string OptionType { get; } = "Golden Frame";
    public decimal OptionPrice { get; } = 149.95m;
}

internal class LeatherSeat : IBikeOptions
{
    public string OptionType { get; } = "Leather Seat";
    public decimal OptionPrice { get; } = 89.99m;
}

internal class LeatherGrips : IBikeOptions
{
    public string OptionType { get; } = "Leather Grips";
    public decimal OptionPrice { get; } = 29.99m;
}

internal class WhiteTires : IBikeOptions
{
    public string OptionType { get; } = "White Tires";
    public decimal OptionPrice { get; } = 19.99m;
}