
namespace TheInterface.Model;
// Corresponds to dreams on the dream-catcher
public class Dream
{
    public string? Name { get; set; }
    
    public float VolumeValue { get; set; }
    
    public float LightValue { get; set; }
    
    public float MovementValue { get; set; }
    
    public float TemperatureValue { get; set; }
    
    public string? Color { get; set; }
    
    public List<InformationBlock>? InformationBlocks { get; set; }
}