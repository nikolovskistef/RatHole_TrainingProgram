using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Exercise_Split
    {
        Upper_Body = 0,
        Lower_Body = 1,
        Push = 2,
        Pull = 3,
        Chest = 4,
        Back = 5,
        Arms = 6,
        Shoulder = 7,
        Legs = 8,
    }
}
