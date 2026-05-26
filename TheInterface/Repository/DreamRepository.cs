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
                    BlockInformation = "Hito leder efter andre væsener i rummet.",
                    BlockInformationHighlight = "Hito leder ... i rummet.",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Hito finder kun en månesten, som er frosset fast til jorden.",
                    BlockInformationHighlight = "... frosset fast til jorden",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Hito svæver rundt om månen ti gange. Den eneste lyd er Hitos egen vejrtrækning.",
                    BlockInformationHighlight = "Den eneste lyd er Hitos egen vejrtrækning.",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Det føles som at flyde rundt under nattens tæppe.",
                    BlockInformationHighlight = "... under nattens tæppe.",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.Low
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
                    BlockInformation = "Hito er helt alene i pyramiden",
                    BlockInformationHighlight = "... helt alene ...",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Det er svært at finde vej, så Hito leder efter en fakkel.",
                    BlockInformationHighlight = "... leder efter en fakkel.",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Hito mærker noget bag sig og løber væk i fuld fart.",
                    BlockInformationHighlight = "... løber væk i fuld fart.",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Sveden drypper ned på Hitos nye fodboldtrøje.",
                    BlockInformationHighlight = "Sveden drypper ...",
                    Sensor = Sensor.Temperature,
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
                    BlockInformation = "Hito står i sin flyverdragt og venter på julemanden.",
                    BlockInformationHighlight = "... står i sin flyverdragt ...",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Sneen glimter i solen.",
                    BlockInformationHighlight = "... glimter i solen.",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "En masse bjælder ringer pludselig. Hito vender sig og ser julemanden med hans rendsdyr.",
                    BlockInformationHighlight = "En masse bjælder ringer pludselig ...",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Hito snupper forsigtigt en pakke, uden at julemanden opdager det.",
                    BlockInformationHighlight = "Hito snupper forsigtigt ...",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.Low
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
                    BlockInformation = "Hito sidder i sin Jeep og kigger ud over savannen.",
                    BlockInformationHighlight = "... kigger ud over savannen.",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Hito ser en løve, som ligger i skyggen af et træ.",
                    BlockInformationHighlight = "... i skyggen af et træ.",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Hito slukker aircondition i Jeepen, for ikke at vække løven.",
                    BlockInformationHighlight = "... for ikke at vække løven.",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Hito kommer til at kigge på sin madpakke, som får maven til at knurre. Løven løfter kort på øjet, og ligger sig til at sove igen.",
                    BlockInformationHighlight = "... ligger sig til at sove igen.",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.Low
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
                    BlockInformation = "Hito prøver at fange en fisk på havets bund.",
                    BlockInformationHighlight = "... prøver at fange en fisk ...",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Lyset når næsten ikke helt derned.",
                    BlockInformationHighlight = "Lyset når næsten ikke helt derned.",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Hioto tisser i sin våddragt for at få varmen.",
                    BlockInformationHighlight = "Pludseligt svømmer fisken hen ...",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Fisken napper fast i Hito! Det kilder i hele kroppen, men under vandet kan Hito ikke grine.",
                    BlockInformationHighlight = "... under vandet kan Hito ikke grine.",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.Low
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
                    BlockInformation = "Hito flyver i skyerne, så kappen blafrer bagud.",
                    BlockInformationHighlight = "... så kappen blafrer bagud.",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Hito tager sine solbriller på for at se, om nogen har brug for hjælp. ",
                    BlockInformationHighlight = "Hito tager sine solbriller på ...",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Hito ser en pige, der er væltet på ski.",
                    BlockInformationHighlight = "... på ski.",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Hito flyver ned og rejser hende op. Det går så hurtigt, at ingen ligger mærke til noget.",
                    BlockInformationHighlight = "... ingen ligger mærke til noget.",
                    Sensor = Sensor.Sound,
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
                    BlockInformation = "Bølgerne er enorme, og skibet gynger op og ned.",
                    BlockInformationHighlight = "... skibet gynger op og ned.",
                    Sensor = Sensor.Shake,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "Hito mister balancen, og falder i vandet med et kæmpe plask.",
                    BlockInformationHighlight = "... med et kæmpe plask.",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "Det er kun Hito, som er nattevagt. Ingen kan derfor hjælpe Hito. ",
                    BlockInformationHighlight = "... som er nattevagt.",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.Low
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Hito griber fat i en palme-stamme, der flyder i vandet.",
                    BlockInformationHighlight = "... fat i en palme-stamme ...",
                    Sensor = Sensor.Temperature,
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
                    BlockInformation = "Hito sætter sig i et varmt sæde i rutsjebanen.",
                    BlockInformationHighlight = "... varmt sæde ...",
                    Sensor = Sensor.Temperature,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 2,
                    BlockInformation = "De solbrændte ben hænger dinglende mod jorden, hvor menneskerne bliver mindre og mindre.",
                    BlockInformationHighlight = "De solbrændte ben ...",
                    Sensor = Sensor.Light,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 3,
                    BlockInformation = "På vej ned skriger Hito så højt, at de næsten kan høre det i Kina.",
                    BlockInformationHighlight = "... skriger Hito så højt ...",
                    Sensor = Sensor.Sound,
                    SensorReadingValue = SensorReadingValue.High
                },
                new InformationBlock
                {
                    BlockNumber = 4,
                    BlockInformation = "Der kommer gnister fra hjulene, fordi rutsjebanen er så vild.",
                    BlockInformationHighlight = "... gnister fra hjulene, fordi rutjebanen er så vild.",
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