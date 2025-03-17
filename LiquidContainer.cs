namespace APBD3;
class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; }

    public LiquidContainer(double maxPayload, bool isHazardous)
        : base("L", maxPayload)
    {
        IsHazardous = isHazardous;
    }

    public override void Load(double mass)
    {
        double maxLoad = IsHazardous ? MaxPayload * 0.5 : MaxPayload * 0.9;
        if (CurrentLoad + mass > maxLoad)
            NotifyHazard("Overfill attempt detected!");
        else
            base.Load(mass);
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard Alert! {message} in {SerialNumber}");
    }
}
