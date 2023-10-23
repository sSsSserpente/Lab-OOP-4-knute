public class Computer
{
    public string IpAddress { get; set; }
    public int Power { get; set; }
    public string OperatingSystem { get; set; }
}

// Inheritance classes: Server, Workstation, Router
public class Server : Computer, IConnectable
{
    public int StorageCapacity { get; set; }

    public void Connect()
    {
        Console.WriteLine("Server connected.");
    }

    public void Disconnect()
    {
        Console.WriteLine("Server disconnected.");
    }

    public void TransferData()
    {
        Console.WriteLine("Server is transferring data.");
    }
}

public class Workstation : Computer, IConnectable
{
    public string Department { get; set; }

    public void Connect()
    {
        Console.WriteLine("Workstation connected.");
    }

    public void Disconnect()
    {
        Console.WriteLine("Workstation disconnected.");
    }

    public void TransferData()
    {
        Console.WriteLine("Workstation is transferring data.");
    }
}

public class Router : Computer, IConnectable
{
    public int Ports { get; set; }

    public void Connect()
    {
        Console.WriteLine("Router connected.");
    }

    public void Disconnect()
    {
        Console.WriteLine("Router disconnected.");
    }

    public void TransferData()
    {
        Console.WriteLine("Router is transferring data.");
    }
}

// Interfaces
public interface IConnectable
{
    void Connect();
    void Disconnect();
    void TransferData();
}

// Class, that modeling an interuction between computers
public class Network
{
    public void Communication(IConnectable device1, IConnectable device2)
    {
        device1.Connect();
        device2.Connect();

        device1.TransferData();
        device2.TransferData();

        device1.Disconnect();
        device2.Disconnect();
    }
}