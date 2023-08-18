using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Muscle_Involvment
    {
        Primary = 0,
        Secondary = 1,
        Tertiary = 2,
    }
}
