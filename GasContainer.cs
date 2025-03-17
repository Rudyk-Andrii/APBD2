namespace APBD3;

class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }

    public GasContainer(double maxPayload, double pressure)
        : base("G", maxPayload)
    {
        Pressure = pressure;
    }

    public override void Unload()
    {
        CurrentLoad *= 0.05; // Leaving 5% of the cargo
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard Alert! {message} in {SerialNumber}");
    }
}
