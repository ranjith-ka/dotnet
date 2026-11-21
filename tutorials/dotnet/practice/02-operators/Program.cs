string serviceName = "payments-api";
int runningPods = 3;
int pendingPods = 2;
bool isHealthy = true;

int totalPods = DeploymentLogic.CalculateTotalPods(runningPods, pendingPods);
int podsAfterScaleDown = DeploymentLogic.CalculatePodsAfterScaleDown(totalPods);

bool hasEnoughPods = DeploymentLogic.HasEnoughPods(runningPods);
bool deploymentSucceeded = DeploymentLogic.DeploymentSucceeded(isHealthy, pendingPods);
bool needsAttention = DeploymentLogic.NeedsAttention(isHealthy, pendingPods);

Console.WriteLine($"Service: {serviceName}");
Console.WriteLine($"Running: {runningPods}, pending: {pendingPods}");
Console.WriteLine($"Total: {totalPods}");
Console.WriteLine($"After scale down: {podsAfterScaleDown}");
Console.WriteLine($"Has enough pods: {hasEnoughPods}");
Console.WriteLine($"Deployment succeeded: {deploymentSucceeded}");
Console.WriteLine($"Needs attention: {needsAttention}");
