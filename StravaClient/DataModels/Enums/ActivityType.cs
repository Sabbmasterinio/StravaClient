namespace StravaClient
{
    /// <summary>
    /// Provides enumeration over the activity types.
    /// </summary>
    /// <remarks>
    /// An enumeration of the types an activity may have. 
    /// Note that this enumeration does not include new 
    /// sport types (e.g. MountainBikeRide, EMountainBikeRide), 
    /// activities with these sport types will have 
    /// the corresponding activity type (e.g. Ride for 
    /// MountainBikeRide, EBikeRide for EMountainBikeRide).
    /// </remarks>
    public enum ActivityType
    {
        /// <summary>
        /// Alpine ski
        /// </summary>
        AlpineSki,

        /// <summary>
        /// Backcountry ski
        /// </summary>
        BackcountrySki,

        /// <summary>
        /// Canoeing
        /// </summary>
        Canoeing,

        /// <summary>
        /// Crossfit
        /// </summary>
        Crossfit,

        /// <summary>
        /// E bike ride
        /// </summary>
        EBikeRide,

        /// <summary>
        /// Elliptical
        /// </summary>
        Elliptical,

        /// <summary>
        /// Golf
        /// </summary>
        Golf,

        /// <summary>
        /// Hand cycle
        /// </summary>
        Handcycle,

        /// <summary>
        /// Hike
        /// </summary>
        Hike,

        /// <summary>
        /// Ice skate
        /// </summary>
        IceSkate,
        /// <summary>
        /// Inline skate
        /// </summary>
        InlineSkate,

        /// <summary>
        /// Kayaking
        /// </summary>
        Kayaking,

        /// <summary>
        /// Kitesurf
        /// </summary>
        Kitesurf,

        /// <summary>
        /// Nordic ski
        /// </summary>
        NordicSki,

        /// <summary>
        /// Ride
        /// </summary>
        Ride,

        /// <summary>
        /// Rock climbing
        /// </summary>
        RockClimbing,

        /// <summary>
        /// Roller ski
        /// </summary>
        RollerSki,

        /// <summary>
        /// Rowing
        /// </summary>
        Rowing,

        /// <summary>
        /// Run
        /// </summary>
        Run,

        /// <summary>
        /// Sail
        /// </summary>
        Sail,

        /// <summary>
        /// Skateboard
        /// </summary>
        Skateboard,

        /// <summary>
        /// Snowboard
        /// </summary>
        Snowboard,

        /// <summary>
        /// Snowshoe
        /// </summary>
        Snowshoe,

        /// <summary>
        /// Soccer
        /// </summary>
        Soccer,

        /// <summary>
        /// Stair stepper
        /// </summary>
        StairStepper,

        /// <summary>
        /// Stand up paddling
        /// </summary>
        StandUpPaddling,

        /// <summary>
        /// Surfing
        /// </summary>
        Surfing,

        /// <summary>
        /// Swim
        /// </summary>
        Swim,

        /// <summary>
        /// Velomobile
        /// </summary>
        Velomobile,

        /// <summary>
        /// Virtual ride
        /// </summary>
        VirtualRide,

        /// <summary>
        /// Virtual run
        /// </summary>
        VirtualRun,

        /// <summary>
        /// Walk
        /// </summary>
        Walk,

        /// <summary>
        /// Weight training
        /// </summary>
        WeightTraining,

        /// <summary>
        /// Wheelchair
        /// </summary>
        Wheelchair,

        /// <summary>
        /// Windsurf
        /// </summary>
        Windsurf,

        /// <summary>
        /// Workout
        /// </summary>
        Workout,

        /// <summary>
        /// Yoga
        /// </summary>
        Yoga
    }

}