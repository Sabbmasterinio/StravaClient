using System.Collections.Immutable;

namespace StravaClient
{
    /// <summary>
    /// Constants related to the Strava client
    /// </summary>
    public static class StravaClientConstants
    {
        /// <summary>
        /// Maps each <see cref="ActivityType"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<ActivityType, string> ActivityTypeToStringMapper { get; } = new Dictionary<ActivityType, string>()
        {
            { ActivityType.AlpineSki, "AlpineSki" },
            { ActivityType.BackcountrySki, "BackcountrySki" },
            { ActivityType.Canoeing, "Canoeing" },
            { ActivityType.Crossfit, "Crossfit" },
            { ActivityType.EBikeRide, "EBikeRide" },
            { ActivityType.Elliptical, "Elliptical" },
            { ActivityType.Golf, "Golf" },
            { ActivityType.Handcycle, "Handcycle" },
            { ActivityType.Hike, "Hike" },
            { ActivityType.IceSkate, "IceSkate" },
            { ActivityType.InlineSkate, "InlineSkate" },
            { ActivityType.Kayaking, "Kayaking" },
            { ActivityType.Kitesurf, "Kitesurf" },
            { ActivityType.NordicSki, "NordicSki" },
            { ActivityType.Ride, "Ride" },
            { ActivityType.RockClimbing, "RockClimbing" },
            { ActivityType.RollerSki, "RollerSki" },
            { ActivityType.Rowing, "Rowing" },
            { ActivityType.Run, "Run" },
            { ActivityType.Sail, "Sail" },
            { ActivityType.Skateboard, "Skateboard" },
            { ActivityType.Snowboard, "Snowboard" },
            { ActivityType.Snowshoe, "Snowshoe" },
            { ActivityType.Soccer, "Soccer" },
            { ActivityType.StairStepper, "StairStepper" },
            { ActivityType.StandUpPaddling, "StandUpPaddling" },
            { ActivityType.Surfing, "Surfing" },
            { ActivityType.Swim, "Swim" },
            { ActivityType.Velomobile, "Velomobile" },
            { ActivityType.VirtualRide, "VirtualRide" },
            { ActivityType.VirtualRun, "VirtualRun" },
            { ActivityType.Walk, "Walk" },
            { ActivityType.WeightTraining, "WeightTraining" },
            { ActivityType.Wheelchair, "Wheelchair" },
            { ActivityType.Windsurf, "Windsurf" },
            { ActivityType.Workout, "Workout" },
            { ActivityType.Yoga, "Yoga" },
        }.ToImmutableDictionary();
    }
}
