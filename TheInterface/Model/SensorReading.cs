namespace TheInterface.Model;

public record SensorReading(
    Func<CaseCard, float> Property,
    float Value,
    float Tolerance
);