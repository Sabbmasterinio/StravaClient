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
            { ActivityType.Yoga, "Yoga" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="ActivityZoneType"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<ActivityZoneType, string> ActivityZoneTypeToStringMapper { get; } = new Dictionary<ActivityZoneType, string>()
        {
            { ActivityZoneType.Heartrate, "heartrate" },
            { ActivityZoneType.Power, "power" }
        }.ToImmutableDictionary();
        
        /// <summary>
        /// Maps each <see cref="AthleteSex"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<AthleteSex, string> AthleteSexToStringMapper { get; } = new Dictionary<AthleteSex, string>()
        {
            { AthleteSex.Male, "M" },
            { AthleteSex.Female, "F" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="ClimbCategory"/> to each <see cref="int"/> representation
        /// </summary>
        public static IReadOnlyDictionary<ClimbCategory, int> ClimbCategoryToIntMapper { get; } = new Dictionary<ClimbCategory, int>()
        {
            { ClimbCategory.NoCategory, 0 },
            { ClimbCategory.One, 1 },
            { ClimbCategory.Two, 2 },
            { ClimbCategory.Three, 3 },
            { ClimbCategory.Four, 4 },
            { ClimbCategory.HorsCategory, 5 }
        }.ToImmutableDictionary();
        
        /// <summary>
        /// Maps each <see cref="ClimbCategory"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<ClimbCategory, string> ClimbCategoryToStringMapper { get; } = new Dictionary<ClimbCategory, string>()
        {
            { ClimbCategory.NoCategory, "NC" },
            { ClimbCategory.One, "4" },
            { ClimbCategory.Two, "3" },
            { ClimbCategory.Three, "2" },
            { ClimbCategory.Four, "1" },
            { ClimbCategory.HorsCategory, "HC" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="GearResourceState"/> to each <see cref="int"/> representation
        /// </summary>
        public static IReadOnlyDictionary<GearResourceState, int> GearResourceStateToIntMapper { get; } = new Dictionary<GearResourceState, int>()
        {
            { GearResourceState.Summary, 2 },
            { GearResourceState.Detail, 3 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="MeasurementPreference"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<MeasurementPreference, string> MeasurementPreferenceToStringMapper { get; } = new Dictionary<MeasurementPreference, string>()
        {
            { MeasurementPreference.Feet, "feet" },
            { MeasurementPreference.Meters, "meters" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="Membership"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<Membership, string> MembershipToStringMapper { get; } = new Dictionary<Membership, string>()
        {
            { Membership.Member, "member" },
            { Membership.Pending, "pending" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="ResourceState"/> to each <see cref="int"/> representation
        /// </summary>
        public static IReadOnlyDictionary<ResourceState, int> ResourceStateToIntMapper { get; } = new Dictionary<ResourceState, int>()
        {
            { ResourceState.Meta, 1 },
            { ResourceState.Summary, 2 },
            { ResourceState.Detail, 3 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="RouteSubType"/> to each <see cref="int"/> representation
        /// </summary>
        public static IReadOnlyDictionary<RouteSubType, int> RouteSubTypeToIntMapper { get; } = new Dictionary<RouteSubType, int>()
        {
            { RouteSubType.Road, 1 },
            { RouteSubType.MountainBike, 2 },
            { RouteSubType.Cross, 3 },
            { RouteSubType.Trail, 4 },
            { RouteSubType.Mixed, 5 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="RouteType"/> to each <see cref="int"/> representation
        /// </summary>
        public static IReadOnlyDictionary<RouteType, int> RouteTypeToIntMapper { get; } = new Dictionary<RouteType, int>()
        {
            { RouteType.Ride, 1 },
            { RouteType.Run, 2 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="SegmentActivityType"/> to each <see cref="string"/> representation
        /// </summary>
        /// 
        public static IReadOnlyDictionary<SegmentActivityType, string> SegmentActivityTypeToStringMapper { get; } = new Dictionary<SegmentActivityType, string>()
        {
            { SegmentActivityType.Ride, "Ride" },
            { SegmentActivityType.Run, "Run" }
        }.ToImmutableDictionary();
        /// <summary>
        /// Maps each <see cref="SportType"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<SportType, string> SportTypeToStringMapper { get; } = new Dictionary<SportType, string>()
        {
            { SportType.AlpineSki, "AlpineSki" },
            { SportType.BackcountrySki, "BackcountrySki" },
            { SportType.Badminton, "Badminton" },
            { SportType.Canoeing, "Canoeing" },
            { SportType.Crossfit, "Crossfit" },
            { SportType.EBikeRide, "EBikeRide" },
            { SportType.Elliptical, "Elliptical" },
            { SportType.EMountainBikeRide, "EMountainBikeRide" },
            { SportType.Golf, "Golf" },
            { SportType.GravelRide, "GravelRide" },
            { SportType.Handcycle, "Handcycle" },
            { SportType.HighIntensityIntervalTraining, "HighIntensityIntervalTraining" },
            { SportType.Hike, "Hike" },
            { SportType.IceSkate, "IceSkate" },
            { SportType.InlineSkate, "InlineSkate" },
            { SportType.Kayaking, "Kayaking" },
            { SportType.Kitesurf, "Kitesurf" },
            { SportType.MountainBikeRide, "MountainBikeRide" },
            { SportType.NordicSki, "NordicSki" },
            { SportType.Pickleball, "Pickleball" },
            { SportType.Pilates, "Pilates" },
            { SportType.Racquetball, "Racquetball" },
            { SportType.Ride, "Ride" },
            { SportType.RockClimbing, "RockClimbing" },
            { SportType.RollerSki, "RollerSki" },
            { SportType.Rowing, "Rowing" },
            { SportType.Run, "Run" },
            { SportType.Sail, "Sail" },
            { SportType.Skateboard, "Skateboard" },
            { SportType.Snowboard, "Snowboard" },
            { SportType.Snowshoe, "Snowshoe" },
            { SportType.Soccer, "Soccer" },
            { SportType.Squash, "Squash" },
            { SportType.StairStepper, "StairStepper" },
            { SportType.StandUpPaddling, "StandUpPaddling" },
            { SportType.Surfing, "Surfing" },
            { SportType.Swim, "Swim" },
            { SportType.TableTennis, "TableTennis" },
            { SportType.Tennis, "Tennis" },
            { SportType.TrailRun, "TrailRun" },
            { SportType.Velomobile, "Velomobile" },
            { SportType.VirtualRide, "VirtualRide" },
            { SportType.VirtualRow, "VirtualRow" },
            { SportType.VirtualRun, "VirtualRun" },
            { SportType.Walk, "Walk" },
            { SportType.WeightTraining, "WeightTraining" },
            { SportType.Wheelchair, "Wheelchair" },
            { SportType.Windsurf, "Windsurf" },
            { SportType.Workout, "Workout" },
            { SportType.Yoga, "Yoga" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="StreamResolution"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<StreamResolution, string> StreamResolutionToStringMapper { get; } = new Dictionary<StreamResolution, string>()
        {
            { StreamResolution.Low, "low" },
            { StreamResolution.Medium, "medium" },
            { StreamResolution.High, "high" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps each <see cref="StreamSeriesType"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<StreamSeriesType, string> StreamSeriesTypeToStringMapper { get; } = new Dictionary<StreamSeriesType, string>()
        {
            { StreamSeriesType.Distance, "distance" },
            { StreamSeriesType.Time, "time" }
        }.ToImmutableDictionary();
        
        /// <summary>
        /// Maps each <see cref="ClubType"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<ClubType, string> ClubTypeToStringMapper { get; } = new Dictionary<ClubType, string>()
        {
            { ClubType.Company, "company" }
        }.ToImmutableDictionary();
        
        /// <summary>
        /// Maps each <see cref="StreamSetType"/> to each <see cref="string"/> representation
        /// </summary>
        public static IReadOnlyDictionary<StreamSetType, string> StreamSetTypeToStringMapper { get; } = new Dictionary<StreamSetType, string>()
        {
            { StreamSetType.Time, "time" },
            { StreamSetType.Distance, "distance" },
            { StreamSetType.Coordinates, "latlng" },
            { StreamSetType.Altitude, "altitude" },
            { StreamSetType.VelocitySmooth, "velocity_smooth" },
            { StreamSetType.Heartrate, "heartrate" },
            { StreamSetType.Cadence, "cadence" },
            { StreamSetType.Watts, "watts" },
            { StreamSetType.Temperature, "temp" },
            { StreamSetType.Moving, "moving" },
            { StreamSetType.GradeSmooth, "grade_smooth" }
        }.ToImmutableDictionary();

    }
}