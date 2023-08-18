using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Exercise_Category
    {
        Strength = 0,
        Hyperthrophy = 1,
        Flexibility = 2,
        Mobility = 3,
        Speed = 4,
        Quickness = 5,
        Explosiveness = 6,
        Conditioning = 7,
        Physio = 8,

    }
}
