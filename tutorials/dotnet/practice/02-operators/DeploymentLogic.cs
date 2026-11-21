public static class DeploymentLogic
{
    public static int CalculateTotalPods(int runningPods, int pendingPods)
    {
        return runningPods + pendingPods;
    }

    public static int CalculatePodsAfterScaleDown(int totalPods)
    {
        return totalPods - 1;
    }

    public static bool HasEnoughPods(int runningPods)
    {
        return runningPods >= 3;
    }

    public static bool DeploymentSucceeded(bool isHealthy, int pendingPods)
    {
        return isHealthy && pendingPods == 0;
    }

    public static bool NeedsAttention(bool isHealthy, int pendingPods)
    {
        return !isHealthy || pendingPods > 0;
    }
}
