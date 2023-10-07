using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Xml.Linq;

namespace StravaClient
{
    /// <summary>
    /// Represents activity stats.
    /// </summary>
    /// <remarks>A set of rolled-up statistics and totals for an athlete.</remarks>
    public class ActivityStatsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="RecentRideTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mRecentRideTotals;
        
        /// <summary>
        /// The member of <see cref="RecentRunTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mRecentRunTotals;
        
        /// <summary>
        /// The member of <see cref="RecentSwimTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mRecentSwimTotals;
        
        /// <summary>
        /// The member of <see cref="YtdRideTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mYtdRideTotals;
        
        /// <summary>
        /// The member of <see cref="YtdRunTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mYtdRunTotals;
        
        /// <summary>
        /// The member of <see cref="YtdSwimTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mYtdSwimTotals;
        
        /// <summary>
        /// The member of <see cref="AllRideTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mAllRideTotals;
        
        /// <summary>
        /// The member of <see cref="AllRunTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mAllRunTotals;
        
        /// <summary>
        /// The member of <see cref="AllSwimTotals"/> property
        /// </summary>
        private ActivityTotalResponseModel? mAllSwimTotals;

        #endregion

        #region Public Properties

        /// <summary>
        /// The longest distance ridden by the athlete.
        /// </summary>
        [JsonProperty("biggest_ride_distance")]
        public double BiggestRideDistance { get; set; }

        /// <summary>
        /// The highest climb ridden by the athlete.
        /// </summary>
        [JsonProperty("biggest_climb_elevation_gain")]
        public double BiggestClimbElevationGain { get; set; }

        /// <summary>
        /// The recent (last 4 weeks) ride stats for the athlete.
        /// </summary>
        [JsonProperty("recent_ride_totals")]
        public ActivityTotalResponseModel RecentRideTotals 
        { 
            get => mRecentRideTotals ??= new(); 
            set => mRecentRideTotals = value; 
        }

        /// <summary>
        /// The recent (last 4 weeks) run stats for the athlete.
        /// </summary>
        [JsonProperty("recent_run_totals")]
        public ActivityTotalResponseModel RecentRunTotals 
        { 
            get => mRecentRunTotals ??= new(); 
            set => mRecentRunTotals = value; 
        }
        
        /// <summary>
        /// The recent (last 4 weeks) swim stats for the athlete.
        /// </summary>
        [JsonProperty("recent_swim_totals")]
        public ActivityTotalResponseModel RecentSwimTotals 
        { 
            get => mRecentSwimTotals ??= new();
            set => mRecentSwimTotals = value; 
        }

        /// <summary>
        /// The year to date ride stats for the athlete.
        /// </summary>
        [JsonProperty("ytd_ride_totals")]
        public ActivityTotalResponseModel YtdRideTotals
        { 
            get => mYtdRideTotals ??= new();
            set => mYtdRideTotals = value; 
        }
        
        /// <summary>
        /// The year to date run stats for the athlete.
        /// </summary>
        [JsonProperty("ytd_run_totals")]
        public ActivityTotalResponseModel YtdRunTotals 
        { 
            get => mYtdRunTotals ??= new(); 
            set => mYtdRunTotals = value; 
        }
        
        /// <summary>
        /// The year to date swim stats for the athlete.
        /// </summary>
        [JsonProperty("ytd_swim_totals")]
        public ActivityTotalResponseModel YtdSwimTotals 
        { 
            get => mYtdSwimTotals ??= new(); 
            set => mYtdSwimTotals =value; 
        }

        /// <summary>
        /// The all time ride stats for the athlete.
        /// </summary>
        [JsonProperty("all_ride_totals")]
        public ActivityTotalResponseModel AllRideTotals 
        { 
            get => mAllRideTotals ??= new();
            set => mAllRideTotals = value;
        }
        
        /// <summary>
        /// The all time run stats for the athlete.
        /// </summary>
        [JsonProperty("all_run_totals")]
        public ActivityTotalResponseModel AllRunTotals 
        {
            get => mAllRunTotals ??= new();
            set => mAllRunTotals =value;
        }
        
        /// <summary>
        /// The all time swim stats for the athlete.
        /// </summary>
        [JsonProperty("all_swim_totals")]
        public ActivityTotalResponseModel AllSwimTotals 
        { 
            get => mAllSwimTotals ??= new();
            set => mAllSwimTotals = value; 
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityStatsResponseModel() : base()
        {

        }
        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents an activity total.
    /// </summary>
    /// <remarks>
    /// A roll-up of metrics pertaining to a set of activities. Values are in seconds and meters.
    /// </remarks>
    public class ActivityTotalResponseModel
    {
        #region Private Members

        #endregion

        #region Public Properties

        /// <summary>
        /// The number of activities considered in this total.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The total distance covered by the considered activities.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The total moving time of the considered activities.
        /// </summary>
        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        /// <summary>
        /// The total elapsed time of the considered activities.
        /// </summary>
        [JsonProperty("elapsed_time")]
        public float ElapsedTime { get; set; }

        /// <summary>
        /// The total elevation gain of the considered activities.
        /// </summary>
        [JsonProperty("elevation_gain")]
        public float ElevationGain { get; set; }

        /// <summary>
        /// The total elevation gain of the considered activities.
        /// </summary>
        [JsonProperty("achievement_count")]
        public float AchievementCount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityTotalResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

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

        ///Surfing <summary>
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

    /// <summary>
    /// Represents an activity zone response model.
    /// </summary>
    public class ActivityZoneResponseModel 
    {
        #region Public Properties

        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("score")]
        public int Score { get; set; }

        /// <summary>
        /// An instance of #/TimedZoneDistribution.
        /// </summary>
        [JsonProperty("distribution_buckets")]
        public TimeZoneInfo DistributionBuckets { get; set; }

        /// <summary>
        /// May take one of the following values: heartrate, power.
        /// </summary>
        [JsonProperty("type")]
        public ActivityZoneType Type { get; set; }
        
        /// <summary>
        /// An instance of boolean.
        /// </summary>
        [JsonProperty("sensor_based")]
        public bool SensorBased { get; set; }
        
        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("points")]
        public bool Points { get; set; }
        
        /// <summary>
        /// An instance of boolean.
        /// </summary>
        [JsonProperty("custom_zones")]
        public bool CustomZones { get; set; }
        
        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("max")]
        public bool Max { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityZoneResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Provides enumeration over the activity zone types.
    /// </summary>
    /// <remarks>Extra enumeration needed for activity zone type.</remarks>
    public enum ActivityZoneType
    {
        /// <summary>
        /// Heartrate
        /// </summary>
        heartrate,

        /// <summary>
        /// Power
        /// </summary>
        power
    }

    /// <summary>
    /// Represents a base stream.
    /// </summary>
    public class BaseStreamResponseModel 
    {
        #region Public Properties

        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("original_size")]
        public int OriginalSize { get; set; }
        
        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("resolution")]
        public StreamResolution Resolution { get; set; }
        
        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("series_type")]
        public StreamSeriesType SeriesType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseStreamResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Provides enumeration over the stream resolutions.
    /// </summary>
    public enum StreamResolution
    {
        /// <summary>
        /// Low
        /// </summary>
        Low,

        /// <summary>
        /// Medium
        /// </summary>
        Medium,

        /// <summary>
        /// High
        /// </summary>
        High
    }

    /// <summary>
    /// Provides enumeration over the stream series types.
    /// </summary>
    public enum StreamSeriesType
    {
        /// <summary>
        /// Distance
        /// </summary>
        Distance,

        /// <summary>
        /// Time
        /// </summary>
        Time
    }

    /// <summary>
    /// Represents a club activity.
    /// </summary>
    public class ClubActivityResponseModel
    {
        #region Private Members
        
        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private MetaAthleteResponseModel? mAthlete;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of MetaAthlete.
        /// </summary>
        [JsonProperty("athlete")]
        public MetaAthleteResponseModel Athlete
        {
            get => mAthlete ??= new();

            set => mAthlete = value;
        }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;

            set => mName = value;
        }

        /// <summary>
        /// The activity's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The activity's moving time, in seconds.
        /// </summary>
        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        /// <summary>
        /// The activity's elapsed time, in seconds.
        /// </summary>
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        /// <summary>
        /// The activity's total elevation gain.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; set; }

        /// <summary>
        /// Deprecated. Prefer to use sport_type.
        /// </summary>
        [JsonProperty("type")]
        public ActivityType Type { get; set; }

        /// <summary>
        /// An instance of SportType.
        /// </summary>
        [JsonProperty("sport_type")]
        public SportType SportType { get; set; }

        /// <summary>
        /// The activity's workout type.
        /// </summary>
        [JsonProperty("workout_type")]
        public int WorkoutType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubActivityResponseModel() : base()
        {

        }

        #endregion

        #region Puclic Methods

        #endregion
    }

    /// <summary>
    /// Represends a club athlete.
    /// </summary>
    public class ClubAthleteResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Firstname"/> property
        /// </summary>
        private string? mFirstname;
        
        /// <summary>
        /// The member of <see cref="Lastname"/> property
        /// </summary>
        private string? mLastname;
        
        /// <summary>
        /// The member of <see cref="Member"/> property
        /// </summary>
        private string? mMember;

        #endregion

        #region Public Properties

        /// <summary>
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".</remarks>
        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        /// <summary>
        /// The athlete's first name.
        /// </summary>
        [AllowNull]
        [JsonProperty("firstname")]
        public string Firstname 
        {
            get => mFirstname ?? string.Empty;
            set => mFirstname = value;
        }

        /// <summary>
        /// The athlete's last initial.
        /// </summary>
        [AllowNull]
        [JsonProperty("lastname")]
        public string Lastname 
        {
            get => mLastname ?? string.Empty;
            set => mLastname = value;
        }

        /// <summary>
        /// The athlete's member status.
        /// </summary>
        [AllowNull]
        [JsonProperty("member")]
        public string Member 
        {
            get => mMember ?? string.Empty;
            set => mMember = value;
        }

        /// <summary>
        /// Whether the athlete is a club admin.
        /// </summary>
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        /// <summary>
        /// Whether the athlete is club owner.
        /// </summary>
        [JsonProperty("owner")]
        public bool Owner { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubAthleteResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents a comment.
    /// </summary>
    public class CommentResponseModel 
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Text"/> property
        /// </summary>
        private string? mText;
        
        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private SummaryAthleteResponseModel? mAthlete;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of this comment.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        
        /// <summary>
        /// The identifier of the activity this comment is related to.
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// The content of the comment.
        /// </summary>
        [AllowNull]
        [JsonProperty("text")]
        public string Text
        {
            get => mText ?? string.Empty;
            set => mText = value;
        }
        
        /// <summary>
        /// An instance of SummaryAthlete.
        /// </summary>
        [JsonProperty("athlete")]
        public SummaryAthleteResponseModel Athlete
        {
            get => mAthlete ??= new();
            set => mAthlete = value;
        }

        /// <summary>
        /// The time at which this comment was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CommentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion

    }

    /// <summary>
    /// Represents an error.
    /// </summary>
    public class ErrorResponseModel 
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Code"/> property
        /// </summary>
        private string? mCode;
        
        /// <summary>
        /// The member of <see cref="Field"/> property
        /// </summary>
        private string? mField;
        
        /// <summary>
        /// The member of <see cref="Resource"/> property
        /// </summary>
        private string? mResource;

        #endregion

        #region Public Properties

        /// <summary>
        /// The code associated with this error.
        /// </summary>
        [AllowNull]
        [JsonProperty("code")]
        public string Code 
        {
            get => mCode ?? string.Empty;
            set => mCode = value;
        }

        /// <summary>
        /// The specific field or aspect of the resource associated with this error.
        /// </summary>
        [AllowNull]
        [JsonProperty("field")]
        public string Field 
        {
            get => mField ?? string.Empty;
            set => mField = value;
        }

        /// <summary>
        /// The type of resource associated with this error.
        /// </summary>
        [AllowNull]
        [JsonProperty("resource")]
        public string Resource 
        {
            get => mResource ?? string.Empty;
            set => mResource = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ErrorResponseModel() : base()
        {

        }
        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents an explorer response.
    /// </summary>
    public class ExplorerResponseResponseModel 
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Segments"/> property
        /// </summary>
        private ExplorerSegmentResponseModel? mSegments;

        #endregion

        #region Public Properties

        /// <summary>
        /// The set of segments matching an explorer request.
        /// </summary>
        [JsonProperty("segments")]
        public ExplorerSegmentResponseModel Segments
        {
            get => mSegments ??= new();
            set => mSegments = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExplorerResponseResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents an explorer segment.
    /// </summary>
    public class ExplorerSegmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;
        
        /// <summary>
        /// The member of <see cref="ClimbCategoryDesc"/> property
        /// </summary>
        private string? mClimbCategoryDesc;
        
        /// <summary>
        /// The member of <see cref="StartLatlng"/> property
        /// </summary>
        private LatLngResponseModel? mStartLatlng;
        
        /// <summary>
        /// The member of <see cref="EndLatlng"/> property
        /// </summary>
        private LatLngResponseModel? mEndLatlng;
        
        /// <summary>
        /// The member of <see cref="Points"/> property
        /// </summary>
        private string? mPoints;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of this segment.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The name of this segment.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }
        /// <summary>
        /// The category of the climb [0, 5]. Higher is harder.
        /// </summary>
        /// <remarks>
        /// ie. 5 is Hors catégorie, 0 is uncategorized in climb_category.
        /// If climb_category = 5, climb_category_desc = HC. If climb_category = 2,
        /// climb_category_desc = 3.
        /// </remarks>
        [JsonProperty("climb_category")]
        public int ClimbCategory { get; set; }

        /// <summary>
        /// The description for the category of the climb.
        /// </summary>
        /// <remarks>
        /// May take one of the following values: NC, 4, 3, 2, 1, HC.
        /// </remarks>
        [AllowNull]
        [JsonProperty("climb_category_desc")]
        public string ClimbCategoryDesc
        {
            get => mClimbCategoryDesc ?? string.Empty;
            set => mClimbCategoryDesc = value;
        }

        /// <summary>
        /// The segment's average grade, in percents.
        /// </summary>
        [JsonProperty("avg_grade")]
        public float AvgGrade { get; set; }

        /// <summary>
        /// An instance of LatLng.
        /// </summary>
        [JsonProperty("start_latlng")]
        public LatLngResponseModel StartLatlng 
        { 
            get => mStartLatlng ??= new(); 
            set => mStartLatlng =value; 
        }
        
        /// <summary>
        /// An instance of LatLng.
        /// </summary>
        [JsonProperty("end_latlng")]
        public LatLngResponseModel EndLatlng 
        { 
            get => mEndLatlng ??= new(); 
            set => mEndLatlng =value; 
        }

        /// <summary>
        /// The segments's evelation difference, in meters.
        /// </summary>
        [JsonProperty("elev_difference")]
        public float ElevDifference { get; set; }
        
        /// <summary>
        /// The segments's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The polyline of the segment.
        /// </summary>
        [AllowNull]
        [JsonProperty("points")]
        public string Points 
        { 
            get => mPoints ?? string.Empty; 
            set => mPoints = value;
        }
            
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExplorerSegmentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents a fault.
    /// </summary>
    /// <remarks>
    /// Encapsulates the errors that may be returned from the API.
    /// </remarks>
    public class FaultResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Errors"/> property
        /// </summary>
        private ErrorResponseModel? mErrors;
        
        /// <summary>
        /// The member of <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// The set of specific errors associated with this fault, if any.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorResponseModel Errors
        {
            get => mErrors ??= new();
            set => mErrors = value;
        }
        
        /// <summary>
        /// The set of specific errors associated with this fault, if any.
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get => mMessage ?? string.Empty;
            set => mMessage = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FaultResponseModel() : base()
        {

        }
        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents a heart rate zone ranges.
    /// </summary>
    public class HeartRateZoneRangesResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Zones"/> property
        /// </summary>
        private IEnumerable<ZoneRangeResponseModel>? mZones;

        #endregion

        #region Public Properties

        /// <summary>
        /// Whether the athlete has set their own custom heart rate zones.
        /// </summary>
        [JsonProperty("custom_zones")]
        public bool CustomZones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("zones")]
        public IEnumerable<ZoneRangeResponseModel> Zones
        {
            get => mZones ?? Enumerable.Empty<ZoneRangeResponseModel>();

            set => mZones = value;
        }

        #endregion

        #region Constructors

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represends a lap.
    /// </summary>
    public class LapResponseModel
    {
        #region Private Methods

        /// <summary>
        /// The member of <see cref="Activity"/> property
        /// </summary>
        private MetaActivityResponseModel? mActivity;
        
        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private MetaAthleteResponseModel? mAthlete;
        
        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of this lap.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// An instance of MetaActivity.
        /// </summary>
        [JsonProperty("activity")]
        public MetaActivityResponseModel Activity 
        { 
            get => mActivity ??= new(); 
            set => mActivity = value; 
        }

        /// <summary>
        /// An instance of MetaAthlete.
        /// </summary>
        [JsonProperty("athlete")]
        public MetaAthleteResponseModel Athlete 
        { 
            get => mAthlete ??= new(); 
            set => mAthlete = value; 
        }

        /// <summary>
        /// The lap's average cadence.
        /// </summary>
        [JsonProperty("average_cadence")]
        public float AverageCadence { get; set; }
        
        /// <summary>
        /// The lap's average speed.
        /// </summary>
        [JsonProperty("average_speed")]
        public float AverageSpeed { get; set; }

        /// <summary>
        /// The lap's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The lap's elapsed time, in seconds.
        /// </summary>
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        /// <summary>
        /// The start index of this effort in its activity's stream.
        /// </summary>
        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        /// <summary>
        /// The end index of this effort in its activity's stream.
        /// </summary>
        [JsonProperty("end_index")]
        public int EndIndex { get; set; }

        /// <summary>
        /// The index of this lap in the activity it belongs to.
        /// </summary>
        [JsonProperty("lap_index")]
        public int LapIndex { get; set; }

        /// <summary>
        /// The maximum speed of this lap, in meters per second.
        /// </summary>
        [JsonProperty("max_speed")]
        public float MaxSpeed { get; set; }

        /// <summary>
        /// The lap's moving time, in seconds.
        /// </summary>
        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        /// <summary>
        /// The name of the lap.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name 
        { 
            get => mName ?? string.Empty;
            set => mName = value; 
        }

        /// <summary>
        /// The athlete's pace zone during this lap.
        /// </summary>
        [JsonProperty("pace_zone")]
        public int PaceZone { get; set; }

        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("split")]
        public int Split { get; set; }

        /// <summary>
        /// The time at which the lap was started.
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The time at which the lap was started in the local timezone.
        /// </summary>
        [JsonProperty("start_date_local")]
        public DateTime StartDateLocal { get; set; }

        /// <summary>
        /// The elevation gain of this lap, in meters.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public LapResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represends a latlng
    /// </summary>
    /// <remarks>
    /// A collection of float objects. A pair of latitude/longitude coordinates, 
    /// represented as an array of 2 floating point numbers.
    /// </remarks>

    public class LatLngResponseModel
    {

    }

    /// <summary>
    /// Represents a meta activity.
    /// </summary>
    public class MetaActivityResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The unique identifier of the activity.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MetaActivityResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represends a meta athlete.
    /// </summary>
    /// 
    public class MetaAthleteResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The unique identifier of the athlete.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion

        #region Constructors

        #endregion
    }

    /// <summary>
    /// Represents a meta club.
    /// </summary>
    public class MetaClubResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The club's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>
        /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
        /// </remarks>
        [JsonProperty("id")]
        public MetaClubResourceState ResourceState { get; set; }

        /// <summary>
        /// The club's name.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name 
        { 
            get => mName ?? string.Empty;
            set => mName = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MetaClubResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Provides enumeration over the meta club resource states
    /// </summary>
    /// <remarks>
    /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
    /// </remarks>
    public enum MetaClubResourceState
    {
        /// <summary>
        /// Meta
        /// </summary>
        meta = 1,

        /// <summary>
        /// Summary
        /// </summary>
        summary,

        /// <summary>
        /// Detail
        /// </summary>
        detail
    }

    /// <summary>
    /// Represents a photo summary
    /// </summary>
    public class PhotosSummaryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Primary"/> property
        /// </summary>
        private PhotosSummaryPrimaryResponseModel? mPrimary;

        #endregion

        #region Public Properties

        /// <summary>
        /// The number of photos.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// An instance of PhotosSummary_primary.
        /// </summary>
        [JsonProperty("primary")]
        public PhotosSummaryPrimaryResponseModel Primary 
        { 
            get => mPrimary ??= new();
            set => mPrimary = value; 
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PhotosSummaryResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents a photo summary primary.
    /// </summary>
    public class PhotosSummaryPrimaryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="UniqueId"/> property
        /// </summary>
        private string? mUniqueId;
        
        /// <summary>
        /// The member of <see cref="Urls"/> property
        /// </summary>
        private string? mUrls;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of long.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        
        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("source")]
        public int Source { get; set; }

        /// <summary>
        /// An instance of string.
        /// </summary>
        [JsonProperty("unique_id")]
        public string UniqueId
        {
            get => mUniqueId ?? string.Empty;
            set => mUniqueId = value;
        }
        
        /// <summary>
        /// An instance of string.
        /// </summary>
        [JsonProperty("unique_id")]
        public string Urls
        {
            get => mUrls ?? string.Empty;
            set => mUrls = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PhotosSummaryPrimaryResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Provides enumaration over the sport types.
    /// </summary>
    /// <remarks>
    /// An enumeration of the sport types an activity 
    /// may have. Distinct from ActivityType in that 
    /// it has new types (e.g. MountainBikeRide)
    /// </remarks>
    public enum SportType
    {
        /// <summary>
        /// Alpine ski.
        /// </summary>
        AlpineSki,

        /// <summary>
        /// Backcountry ski
        /// </summary>
        BackcountrySki,

        /// <summary>
        /// Badminton
        /// </summary>
        Badminton,

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
        /// E mountain bike ride
        /// </summary>
        EMountainBikeRide,

        /// <summary>
        /// Golf
        /// </summary>
        Golf,

        /// <summary>
        /// Gravel ride
        /// </summary>
        GravelRide,

        /// <summary>
        /// Hand cycle
        /// </summary>
        Handcycle,

        /// <summary>
        /// High intensity interval training
        /// </summary>
        HighIntensityIntervalTraining,

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
        /// Mountain bike ride
        /// </summary>
        MountainBikeRide,

        /// <summary>
        /// Nordic ski
        /// </summary>
        NordicSki,

        /// <summary>
        /// Pickleball
        /// </summary>
        Pickleball,

        /// <summary>
        /// Pilates
        /// </summary>
        Pilates,

        /// <summary>
        /// Racquetball
        /// </summary>
        Racquetball,

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
        /// Squash
        /// </summary>
        Squash,

        /// <summary>
        /// Stair stepper
        /// </summary>
        StairStepper,

        /// <summary>
        /// Stand up paddling
        /// </summary>
        StandUpPaddling,

        ///Surfing <summary>
        /// Surfing
        /// </summary>
        Surfing,

        /// <summary>
        /// Swim
        /// </summary>
        Swim,

        /// <summary>
        /// Table tennis
        /// </summary>
        TableTennis,

        /// <summary>
        /// Tennis
        /// </summary>
        Tennis,

        /// <summary>
        /// Trail run
        /// </summary>
        TrailRun,

        /// <summary>
        /// Velomobile
        /// </summary>
        Velomobile,

        /// <summary>
        /// Virtual ride
        /// </summary>
        VirtualRide,

        /// <summary>
        /// Virtual row
        /// </summary>
        VirtualRow,

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

    /// <summary>
    /// Represents a zone range.
    /// </summary>
    public class ZoneRangeResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The minimum value in the range.
        /// </summary>
        [JsonProperty("min")]
        public int Min { get; set; }
        
        /// <summary>
        /// The maximum value in the range.
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ZoneRangeResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

    /// <summary>
    /// Represents a summary athlete response model.
    /// </summary>
    public class SummaryAthleteResponseModel
    {
    }

}