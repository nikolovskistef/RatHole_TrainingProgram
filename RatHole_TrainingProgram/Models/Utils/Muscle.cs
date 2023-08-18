using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Muscle
    {
        Upper_Chest = 0,
        Lower_Chest = 1,
        Front_Delts = 2,
        Back_Delts = 3,
        Side_Delts = 4,
        Biceps_Brachii = 5,
        Triceps_Brachii = 6,
        Forearms = 7,
        Quads = 8,
        Hamstrings = 9,
        Calfs = 10,
        Upper_Back = 11,
        Lower_Back = 12,
        Mid_Back = 13,
        Pectoralis_Major = 14,
        Pectoralis_Minor = 15,
        Serratus_Anterior = 16,
        Subclavius = 17,
        Deltoid_Anterior = 18,
        Deltoid_Lateral = 19,
        Deltoid_Posterior = 20,
        Supraspinatus = 21,
        Infraspinatus = 22,
        Teres_Minor = 23,
        Subscapularis = 24,
        Trapezius_Upper = 25,
        Trapezius_Middle = 26,
        Trapezius_Lower = 27,
        Levator_Scapulae = 28,
    }
}
