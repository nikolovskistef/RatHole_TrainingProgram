using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Exercise_Method
    {
        Isometric = 0,
        Drop_Set = 1,
        Interval = 3,
        BodyWeight = 4,
    }
}
