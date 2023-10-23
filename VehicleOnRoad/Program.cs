public class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int NumberOfLanes { get; set; }
    public int TrafficLevel { get; set; }
}
public class Vehicle : IDriveable
{
    public string Type { get; set; }
    public double Speed { get; set; }
    public double Size { get; set; }

    public void Move()
    {
        Console.WriteLine($"The {Type} is moving at a speed of {Speed} km/h.");
    }

    public void Stop()
    {
        Console.WriteLine($"The {Type} has stopped.");
    }
}
public interface IDriveable
{
    void Move();
    void Stop();
}

// A class that simulates the movement and change of movement of various vehicles
public class TrafficSimulator
{
    public void SimulateTraffic(List<Vehicle> vehicles, Road road)
    {
        Console.WriteLine($"Simulating traffic on a road of length {road.Length} km, width {road.Width} m, and {road.NumberOfLanes} lanes.");

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle Type: {vehicle.Type}, Size: {vehicle.Size} m², Speed: {vehicle.Speed} km/h");

            if (vehicle.Speed > 0)
            {
                vehicle.Move();
            }
            else
            {
                vehicle.Stop();
            }
        }

        Console.WriteLine($"Traffic simulation on the road with a traffic level of {road.TrafficLevel} completed.");
    }
}