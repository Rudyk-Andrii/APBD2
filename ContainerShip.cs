namespace APBD3;

class ContainerShip
{
    public string Name { get; }
    public double MaxSpeed { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }
    private List<Container> Containers = new List<Container>();

    public ContainerShip(string name, double maxSpeed, int maxContainers, double maxWeight)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers || GetTotalWeight() + container.MaxPayload > MaxWeight)
            throw new Exception("Ship cannot hold more containers!");
        Containers.Add(container);
    }

    public void RemoveContainer(string serialNumber)
    {
        Containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }

    private double GetTotalWeight()
    {
        double total = 0;
        foreach (var container in Containers)
        {
            total += container.MaxPayload;
        }
        return total;
    }

    public override string ToString()
    {
        return $"Ship {Name}: Speed {MaxSpeed}, Containers {Containers.Count}/{MaxContainers}, Weight {GetTotalWeight()}/{MaxWeight}";
    }
}