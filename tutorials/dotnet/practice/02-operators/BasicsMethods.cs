// Foundations: method arguments and return values.
public static class BasicsMethods
{
    public static void Run()
    {
        int runningPods = 3;

        // Pass an argument; assign the returned bool to a variable.
        bool hasEnoughPods = DeploymentLogic.HasEnoughPods(runningPods);

        Console.WriteLine($"Running pods: {runningPods}");
        Console.WriteLine($"Has enough pods: {hasEnoughPods}");
    }
}
