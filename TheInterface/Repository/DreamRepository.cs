using TheInterface.Model;

namespace TheInterface.Repository;

public class DreamRepository
{
    private List<Dream> _dreams =
    [
        // Månen
        new()
        {
            Name = "Månen", 
            LightValue = 0.25f, VolumeValue = 0.25f, MovementValue = 0.25f, TemperatureValue = 0.25f, 
            Color = "#B0BEC5",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
        
        // Pyramiden
        new()
        {
            Name = "Pyramiden", 
            LightValue = 0.25f, VolumeValue = 0.25f, MovementValue = 0.75f, TemperatureValue = 0.75f, 
            Color = "#F9A825",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
        
        // Nordpolen
        new()
        {
            Name = "Nordpolen", 
            LightValue = 0.75f, VolumeValue = 0.75f, MovementValue = 0.25f, TemperatureValue = 0.25f, 
            Color = "#90CAF9",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
        
        // Safari
        new()
        {
            Name = "Safari", 
            LightValue = 0.75f, VolumeValue = 0.25f, MovementValue = 0.25f, TemperatureValue = 0.75f, 
            Color = "#8D6E63",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
        
        // Havet
        new()
        {
            Name = "Havet", 
            LightValue = 0.25f, VolumeValue = 0.25f, MovementValue = 0.75f, TemperatureValue = 0.25f, 
            Color = "#0D47A1",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
        
        // Superhelt
        new()
        {
            Name = "Superhelt", 
            LightValue = 0.75f, VolumeValue = 0.25f, MovementValue = 0.75f, TemperatureValue = 0.25f, 
            Color = "#6A1B9A",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
        
        // Pirat
        new()
        {
            Name = "Pirat", 
            LightValue = 0.25f, VolumeValue = 0.75f, MovementValue = 0.75f, TemperatureValue = 0.75f, 
            Color = "#BF360C",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
        
        // Tivoli
        new()
        {
            Name = "Tivoli", 
            LightValue = 0.75f, VolumeValue = 0.75f, MovementValue = 0.75f, TemperatureValue = 0.75f, 
            Color = "#F48FB1",
            InformationBlocks = new()
            {
                new InformationBlock
                {
                    BlockNumber = 1,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Test test test vigtig information test test",
                    BlockInformationHighlight = "vigtig information",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                }
            }
        },
    ];

    public List<Dream> GetDreams()
    {
        return _dreams;
    }
}