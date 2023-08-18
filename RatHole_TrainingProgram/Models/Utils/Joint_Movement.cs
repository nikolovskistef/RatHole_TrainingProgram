using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Joint_Movement
    {
        Flexion = 0,
        Extension = 1,
        Rotation = 2,
        Abduction = 3,
        Adduction = 4,
        Cicumduction = 5,
    }
}
