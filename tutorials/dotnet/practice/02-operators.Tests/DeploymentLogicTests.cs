using Xunit;

public class DeploymentLogicTests
{
    [Theory]
    [InlineData(2, false)]
    [InlineData(3, true)]
    [InlineData(4, true)]
    public void HasEnoughPods_RequiresAtLeastThreeRunningPods(int runningPods, bool expected)
    {
        bool result = DeploymentLogic.HasEnoughPods(runningPods);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalculateTotalPods_AddsRunningAndPendingPods()
    {
        int result = DeploymentLogic.CalculateTotalPods(3, 2);

        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(true, 0, true)]
    [InlineData(true, 2, false)]
    [InlineData(false, 0, false)]
    public void DeploymentSucceeded_RequiresHealthyDeploymentWithNoPendingPods(
        bool isHealthy,
        int pendingPods,
        bool expected)
    {
        bool result = DeploymentLogic.DeploymentSucceeded(isHealthy, pendingPods);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(true, 0, false)]
    [InlineData(true, 2, true)]
    [InlineData(false, 0, true)]
    public void NeedsAttention_WhenUnhealthyOrPodsArePending(
        bool isHealthy,
        int pendingPods,
        bool expected)
    {
        bool result = DeploymentLogic.NeedsAttention(isHealthy, pendingPods);

        Assert.Equal(expected, result);
    }
}
