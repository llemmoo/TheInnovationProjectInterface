using TheInterface.Model;

namespace TheInterface.Repository;

public class DreamRepository
{
    private List<Dream> _dreams =
    [
        new() { Name = "Månen", LightValue = 0.25f, VolumeValue = 0.25f, MovementValue = 0.25f, TemperatureValue = 0.25f, Color = "#B0BEC5" },
        new() { Name = "Pyramiden", LightValue = 0.25f, VolumeValue = 0.25f, MovementValue = 0.75f, TemperatureValue = 0.75f, Color = "#F9A825" },
        new() { Name = "Nordpolen", LightValue = 0.75f, VolumeValue = 0.75f, MovementValue = 0.25f, TemperatureValue = 0.25f, Color = "#90CAF9" },
        new() { Name = "Safari", LightValue = 0.75f, VolumeValue = 0.25f, MovementValue = 0.25f, TemperatureValue = 0.75f, Color = "#8D6E63" },
        new() { Name = "Havet", LightValue = 0.25f, VolumeValue = 0.25f, MovementValue = 0.75f, TemperatureValue = 0.25f, Color = "#0D47A1" },
        new() { Name = "Superhelt", LightValue = 0.75f, VolumeValue = 0.25f, MovementValue = 0.75f, TemperatureValue = 0.25f, Color = "#6A1B9A" },
        new() { Name = "Pirat", LightValue = 0.25f, VolumeValue = 0.75f, MovementValue = 0.75f, TemperatureValue = 0.75f, Color = "#BF360C" },
        new() { Name = "Tivoli", LightValue = 0.75f, VolumeValue = 0.75f, MovementValue = 0.75f, TemperatureValue = 0.75f, Color = "#F48FB1" },
    ];

    public List<Dream> GetDreams()
    {
        return _dreams;
    }
}