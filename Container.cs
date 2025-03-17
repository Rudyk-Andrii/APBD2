namespace APBD3;

abstract class Container
{
    private static int counter = 1;
    public string SerialNumber { get; }
    public double MaxPayload { get; }
    public double CurrentLoad { get; protected set; }

    protected Container(string type, double maxPayload)
    {
        SerialNumber = $"KON-{type}-{counter++}";
        MaxPayload = maxPayload;
        CurrentLoad = 0;
    }

    public virtual void Load(double mass)
    {
        if (CurrentLoad + mass > MaxPayload)
            throw new Exception("OverfillException: Load exceeds max capacity");
        CurrentLoad += mass;
    }

    public virtual void Unload()
    {
        CurrentLoad = 0;
    }

    public override string ToString()
    {
        return $"Container {SerialNumber}: Load {CurrentLoad}/{MaxPayload}";
    }
}
