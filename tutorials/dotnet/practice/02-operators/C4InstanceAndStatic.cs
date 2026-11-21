// C4: instance and static method calls.
public static class C4InstanceAndStatic
{
    public static void Run()
    {
        var orders = new KubernetesDeployment(3);
        orders.Name = "orders-api";
        orders.Namespace = "default";

        // Instance call: reads the orders object's properties.
        orders.PrintStatus();

        // Static call: use the class name; pass a property value as an argument.
        bool hasEnoughPods = DeploymentLogic.HasEnoughPods(orders.Replicas);

        // Static call: use the Console class, without creating an object.
        Console.WriteLine($"Orders has enough pods: {hasEnoughPods}");
    }
}
