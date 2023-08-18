using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Muscle_Role
    {
        Protagonist = 0,
        Antagonist = 1,
    }
}
