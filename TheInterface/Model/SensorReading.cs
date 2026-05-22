namespace TheInterface.Model;

// Defines a sensor reading, and it's tolerance
public record SensorReading(
    Func<Dream, float> Property,
    float Value,
    float Tolerance
);