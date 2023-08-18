using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Joint
    {
        Right_Elbow = 0,
        Left_Elbow = 1,
        Right_Knee = 2,
        Left_Knee = 3,
        Right_Hip = 4,
        Left_Hip = 5,
        Right_Shoulder = 6,
        Left_Shoulder = 7,
        Right_Wrist = 8,
        Left_Wrist = 9,
        Right_Ankle = 5,
        Left_Ankle = 6,
    }
}
