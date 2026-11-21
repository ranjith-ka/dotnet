// C5: shared references versus separate objects.
public static class C5SharedReferences
{
    public static void Run()
    {
        var first = new KubernetesDeployment(3);

        // Copy the reference: both variables refer to one object.
        var second = first;
        second.Replicas = 5;
        Console.WriteLine($"Shared reference: {first.Replicas}");

        var separateFirst = new KubernetesDeployment(3);

        // Another new call creates a separate object.
        var separateSecond = new KubernetesDeployment(5);
        Console.WriteLine($"Separate objects: {separateFirst.Replicas}");
    }
}
