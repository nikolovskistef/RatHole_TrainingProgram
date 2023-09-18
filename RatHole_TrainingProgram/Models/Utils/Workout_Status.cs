using System.Text.Json.Serialization;

namespace RatHole_TrainingProgram.Models.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Workout_Status  
    {
        Assigned = 0,   //Workout is just being assigned
        Completed = 1,  //Workout has been completed, but not recorded
        Recorded = 2,   //Workout has been completed and recorded for tracking
        Postponed = 3,  //Workout has been postponed
        Canceled = 4,   //Workout has been canceled
    }
}
