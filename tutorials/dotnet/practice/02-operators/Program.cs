// Foundations track: pass a number into a method and read its answer.
int runningPods = 2;
bool hasEnoughPods = DeploymentLogic.HasEnoughPods(runningPods);

Console.WriteLine($"Running pods: {runningPods}");
Console.WriteLine($"Has enough pods: {hasEnoughPods}");
