namespace TheInterface.Model;

public class CaseCard
{
    public string Name { get; set; }
    public float VolumeValue { get; set; }
    public float LightValue { get; set; }
    public float MovementValue { get; set; }
    
    public float TemperatureValue { get; set; }
    public GenderEnum AssumedGender { get; set; }
    public string? Color { get; set; }
    
}