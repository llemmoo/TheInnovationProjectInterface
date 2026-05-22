using TheInterface.Model;

namespace TheInterface.Core;

public class DreamGuesser
{ 
    private readonly IReadOnlyList<Dream> _allDreams;

    public DreamGuesser(IEnumerable<Dream> allCases)
        => _allDreams = allCases.ToList();
    
    public IReadOnlyList<Dream> Evaluate(
        IEnumerable<SensorReading> activeReadings)
    {
        return _allDreams.Where(dream =>
            activeReadings.All(r => Matches(dream, r))
        ).ToList();
    }

    private bool Matches(Dream dream, SensorReading reading)
        => Math.Abs(reading.Property(dream) - reading.Value) <= reading.Tolerance;
}