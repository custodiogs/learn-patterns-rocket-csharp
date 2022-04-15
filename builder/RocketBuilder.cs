public class RocketBuilder : IRocketWorkflow, IRocketWorkflowMaxWeight, IRocketWorkflowMaxSpeed
{
    private RocketBuilder(){}

    private double MaxWeight;
    private double MaxSpeed;

    public static IRocketWorkflow Configure() => new RocketBuilder();

    public IRocketWorkflow SetMaxWeight(double maxHeight)
    {
        MaxWeight = maxHeight;
        return this;
    }
    public IRocketWorkflow SetMaxSpeed(double maxSpeed) {
        MaxSpeed = maxSpeed;
        return this;
    }
    public double GetMaxWeight() => MaxWeight;
    public double GetMaxSpeed() => MaxSpeed;
}