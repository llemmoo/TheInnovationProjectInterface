using System.IO.Ports;

namespace TheInterface.Core;

public class MicroBitReader : BackgroundService
{
    private const string Port = "/dev/tty.usbmodem3102";
    private const int BaudRate = 115200;
    
    private readonly Queue<float> _shakeHistory = new();
    private const int ShakeWindow = 20; // ~2 seconds at 100ms intervals
    public float SoundLevel { get; private set; }
    public float LightLevel { get; private set; }
    public float TemperatureLevel { get; private set; }
    public float ShakeLevel { get; private set; }
    public bool IsLightConnected { get; private set; }
    public event Action? OnSoundLevelChanged;
    public event Action? OnLightLevelChanged;
    public event Action? OnTemperatureLevelChanged;
    public event Action? OnShakeLevelChanged;


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var port = new SerialPort(Port, BaudRate);
        
        port.ReadTimeout = 2000;
        port.NewLine = "\r\n";

        Console.WriteLine($"Opening {Port} at {BaudRate} baud...");
        port.Open();
        Console.WriteLine("Connected! Reading microphone data. Press Ctrl+C to stop.\n");
            
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var data = port.ReadLine().Trim();

                var dataSplit = data.Split(",");

                if (dataSplit.Length < 1) continue;

                if (int.TryParse(dataSplit[0], out var soundLevel) && soundLevel > 0)
                {
                    SoundLevel = soundLevel / 255f;
                    OnSoundLevelChanged?.Invoke();
                }
                
                if (dataSplit.Length < 2) continue;

                if (float.TryParse(dataSplit[1], out var lightLevel) && !float.IsNaN(lightLevel) && lightLevel >= 0 )
                {
                    LightLevel = lightLevel / 255.0f;
                    OnLightLevelChanged?.Invoke();
                }
                
                IsLightConnected = !float.IsNaN(lightLevel) && lightLevel >= 0;
                
                if (dataSplit.Length < 3) continue;

                if (int.TryParse(dataSplit[2], out var temperature))
                {
                    TemperatureLevel = Math.Clamp((temperature - 19f) / 7f, 0f, 1f);
                    OnTemperatureLevelChanged?.Invoke();
                }
                
                if (dataSplit.Length < 4) continue;


                if (int.TryParse(dataSplit[3], out var shake))
                {
                    var normalized = Math.Clamp(Math.Abs(shake) / 1024f, 0f, 1f);
                    _shakeHistory.Enqueue(normalized);
                    if (_shakeHistory.Count > ShakeWindow)
                        _shakeHistory.Dequeue();
                    ShakeLevel = _shakeHistory.Average();
                    OnShakeLevelChanged?.Invoke();
                }

                Console.WriteLine($"Sound level: {soundLevel}");
                Console.WriteLine($"Light level: {lightLevel}");
                Console.WriteLine($"Temperature: {temperature}");
                Console.WriteLine($"Shake: {shake}");

                await Task.Delay(10, stoppingToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}