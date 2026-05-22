namespace TheInterface.Model;

// Defines information blocks and which sensor/value the Data Robot expects from the information block
public class InformationBlock
{
    public int BlockNumber { get; set; }
    
    public string? BlockInformation { get; set; }
    
    public string? BlockInformationHighlight { get; set; }
    
    public Sensor Sensor { get; set; }
    
    public SensorReadingValue SensorReadingValue { get; set; }
}