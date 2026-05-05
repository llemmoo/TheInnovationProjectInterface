using TheInterface.Model;

namespace TheInterface.Core;

public class CaseGuesser
{ 
    private readonly IReadOnlyList<CaseCard> _allCases;

    public CaseGuesser(IEnumerable<CaseCard> allCases)
        => _allCases = allCases.ToList();
    
    public IReadOnlyList<CaseCard> Evaluate(
        IEnumerable<SensorReading> activeReadings)
    {
        return _allCases.Where(card =>
            activeReadings.All(r => Matches(card, r))
        ).ToList();
    }

    private bool Matches(CaseCard card, SensorReading reading)
        => Math.Abs(reading.Property(card) - reading.Value) <= reading.Tolerance;
}