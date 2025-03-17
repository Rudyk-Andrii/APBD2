namespace APBD3;

class RefrigeratedContainer : Container
{
    private static readonly Dictionary<string, double> ProductTemperatures = new()
    {
        { "Bananas", 13.3 },
        { "Fish", -2 },
        { "Meat", -18 },
        { "Dairy", 4 },
        { "Frozen Vegetables", -20 }
    };

    public string ProductType { get; }
    public double RequiredTemperature { get; }

    public RefrigeratedContainer(double maxPayload, string productType)
        : base("C", maxPayload)
    {
        if (!ProductTemperatures.ContainsKey(productType))
            throw new Exception("Invalid product type!");
        
        ProductType = productType;
        RequiredTemperature = ProductTemperatures[productType];
    }

    public override string ToString()
    {
        return base.ToString() + $", Product: {ProductType}, Temp: {RequiredTemperature}°C";
    }
}
