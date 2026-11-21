// Declare a public class named KubernetesDeployment.
public class KubernetesDeployment
{
    // Declare properties that hold each object's state.
    public string Name { get; set; } = "";
    public string Namespace { get; set; } = "";
    public int Replicas { get; set; }

    // Declare a constructor with one integer parameter.
    public KubernetesDeployment(int replicas)
    {
        // Assign the parameter replicas to this object's Replicas property.
        Replicas = replicas;
    }

    // Declare a public instance method. void means it returns no value.
    // PrintStatus provides behavior: it prints this object's current state.
    public void PrintStatus()
    {
        Console.WriteLine($"{Name} in {Namespace} has {Replicas} replica(s)");
    }
}
