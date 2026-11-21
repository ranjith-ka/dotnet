// C3: constructor arguments, parameters, and property assignment.
public static class C3Constructors
{
    public static void Run()
    {
        // Pass the argument 7 to the constructor's parameter replicas.
        var orders = new KubernetesDeployment(7);

        // Read the property assigned by the constructor.
        Console.WriteLine($"Constructor assigned replicas: {orders.Replicas}");
    }
}
