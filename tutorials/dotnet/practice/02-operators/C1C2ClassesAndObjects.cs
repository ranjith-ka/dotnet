// C1 + C2: classes, objects, state, and behavior.
public static class C1C2ClassesAndObjects
{
    public static void Run()
    {
        // Create an object; payments holds its reference.
        var payments = new KubernetesDeployment(3);

        // Assign properties: this is the object's state.
        payments.Name = "payments-api";
        payments.Namespace = "default";

        // Change state, then call an instance method (behavior).
        payments.Replicas = 5;
        payments.PrintStatus();
    }
}
