using Newtonsoft.Json;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a summary activity.
    /// </summary>
    public class SummaryActivityResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="ExternalId"/> property
        /// </summary>
        private string? mExternalId;
        
        /// <summary>
        /// The member of <see cref="UploadId"/> property
        /// </summary>
        private string? mUploadId;

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of <see cref="GearId"/> property
        /// </summary>
        private string? mGearId;

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private MetaAthleteResponseModel? mAthlete;

        /// <summary>
        /// The member of <see cref="TimeZone"/> property
        /// </summary>
        private string? mTimeZone;

        /// <summary>
        /// The member of <see cref="Map"/> property
        /// </summary>
        private PolylineMapResponseModel? mMap;
        
        /// <summary>
        /// The member of <see cref="LocationCity"/> property
        /// </summary>
        private string? mLocationCity;
        
        /// <summary>
        /// The member of <see cref="LocationState"/> property
        /// </summary>
        private string? mLocationState;
        
        /// <summary>
        /// The member of <see cref="LocationCountry"/> property
        /// </summary>
        private string? mLocationCountry;

        #endregion

        #region Public Properties

        /// <summary>
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>
        /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
        /// </remarks>
        [JsonProperty("resource_state")]
        [JsonConverter(typeof(ResourceStateToIntJsonConverter))]
        public ResourceState ResourceState { get; set; }

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
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan MovingTime { get; set; }

        /// <summary>
        /// The activity's elapsed time, in seconds.
        /// </summary>
        [JsonProperty("elapsed_time")]
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan ElapsedTime { get; set; }

        /// <summary>
        /// The activity's total elevation gain.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; set; }

        /// <summary>
        /// An instance of SportType.
        /// </summary>
        [JsonProperty("sport_type")]
        [JsonConverter(typeof(SportTypeToStringJsonConverter))]
        public SportType SportType { get; set; }

        /// <summary>
        /// The activity's workout type.
        /// </summary>
        [JsonProperty("workout_type")]
        public int? WorkoutType { get; set; }

        /// <summary>
        /// The unique identifier of the activity.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The identifier provided at upload time.
        /// </summary>
        [AllowNull]
        [JsonProperty("external_id")]
        public string ExternalId
        {
            get => mExternalId ?? string.Empty;
            set => mExternalId = value;
        }

        /// <summary>
        /// The identifier of the upload that resulted in this activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("upload_id")]
        public string? UploadId
        {
            get => mUploadId ?? string.Empty;
            set => mUploadId = value;
        }

        /// <summary>
        /// The time at which the activity was started.
        /// </summary>
        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The time at which the activity was started in the local timezone.
        /// </summary>
        [JsonProperty("start_date_local")]
        public DateTimeOffset StartDateLocal { get; set; }

        /// <summary>
        /// The timezone of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("timezone")]
        public string TimeZone
        {
            get => mTimeZone ?? string.Empty;
            set => mTimeZone = value;
        }

        /// <summary>
        /// Utc offset.
        /// </summary>
        [JsonProperty("utc_offset")]
        public int UtcOffset { get; set; }

        /// <summary>
        /// A set of starting point latitude and longitude
        /// </summary>
        [JsonProperty("start_latlng")]
        [JsonConverter(typeof(CoordinatesToDoubleArrayJsonConverter))]
        public Coordinates? StartCoordinates { get; set; }

        /// <summary>
        /// A set of ending point latitude and longitude
        /// </summary>
        [JsonProperty("end_latlng")]
        [JsonConverter(typeof(CoordinatesToDoubleArrayJsonConverter))]
        public Coordinates? EndCoordinates { get; set; }

        /// <summary>
        /// The location city of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("location_city")]
        public string LocationCity
        {
            get => mLocationCity ?? string.Empty;
            set => mLocationCity = value;
        }

        /// <summary>
        /// The location state of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("location_state")]
        public string LocationState
        {
            get => mLocationState ?? string.Empty;
            set => mLocationState = value;
        }

        /// <summary>
        /// The location country of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("location_country")]
        public string LocationCountry
        {
            get => mLocationCountry ?? string.Empty;
            set => mLocationCountry = value;
        }

        /// <summary>
        /// The number of achievements gained during this activity.
        /// </summary>
        [JsonProperty("achievement_count")]
        public int AchievementCount { get; set; }

        /// <summary>
        /// The number of kudos given for this activity.
        /// </summary>
        [JsonProperty("kudos_count")]
        public int KudosCount { get; set; }

        /// <summary>
        /// The number of comments for this activity.
        /// </summary>
        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        /// <summary>
        /// The number of athletes for taking part in a group activity.
        /// </summary>
        [JsonProperty("athlete_count")]
        public int AthleteCount { get; set; }

        /// <summary>
        /// The number of Instagram photos for this activity.
        /// </summary>
        [JsonProperty("photo_count")]
        public int PhotoCount { get; set; }

        /// <summary>
        /// An instance of PolylineMap.
        /// </summary>
        [JsonProperty("map")]
        public PolylineMapResponseModel Map
        {
            get => mMap ??= new();
            set => mMap = value;
        }

        /// <summary>
        /// Whether this activity was recorded on a training machine.
        /// </summary>
        [JsonProperty("trainer")]
        public bool IsTrainer { get; set; }

        /// <summary>
        /// Whether this activity is a commute.
        /// </summary>
        [JsonProperty("commute")]
        public bool IsCommute { get; set; }

        /// <summary>
        /// Whether this activity was created manually.
        /// </summary>
        [JsonProperty("manual")]
        public bool IsManual { get; set; }

        /// <summary>
        /// Whether this activity is private.
        /// </summary>
        [JsonProperty("private")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Whether this activity is flagged.
        /// </summary>
        [JsonProperty("flagged")]
        public bool IsFlagged { get; set; }

        /// <summary>
        /// The id of the gear for the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("gear_id")]
        public string GearId
        {
            get => mGearId ?? string.Empty;
            set => mGearId = value;
        }

        /// <summary>
        /// From accepted tag.
        /// </summary>
        [JsonProperty("from_accepted_tag")]
        public bool? IsFromAcceptedTag { get; set; }

        /// <summary>
        /// The activity's average speed, in meters per second.
        /// </summary>
        [JsonProperty("average_speed")]
        public float AverageSpeed { get; set; }

        /// <summary>
        /// The activity's max speed, in meters per second.
        /// </summary>
        [JsonProperty("max_speed")]
        public float MaxSpeed { get; set; }

        /// <summary>
        /// The effort's average cadence.
        /// </summary>
        [JsonProperty("average_cadence")]
        public float AverageCadence { get; set; }

        /// <summary>
        /// Average power output in watts during this activity. Rides only.
        /// </summary>
        [JsonProperty("average_watts")]
        public float AverageWatts { get; set; }

        /// <summary>
        /// Similar to Normalized Power. Rides with power meter data only.
        /// </summary>
        [JsonProperty("weighted_average_watts")]
        public int WeightedAverageWatts { get; set; }

        /// <summary>
        /// The total work done in kilojoules during this activity. Rides only.
        /// </summary>
        [JsonProperty("kilojoules")]
        public float Kilojoules { get; set; }

        /// <summary>
        /// Whether the watts are from a power meter, false if estimated.
        /// </summary>
        [JsonProperty("device_watts")]
        public bool IsDeviceWatts { get; set; }

        /// <summary>
        /// Has heart rate.
        /// </summary>
        [JsonProperty("has_heartrate")]
        public bool HasHeartrate { get; set; }

        /// <summary>
        /// The heart heart rate of the athlete during this effort.
        /// </summary>
        [JsonProperty("average_heartrate")]
        public float AverageHeartrate { get; set; }

        /// <summary>
        /// The maximum heart rate of the athlete during this effort.
        /// </summary>
        [JsonProperty("max_heartrate")]
        public float MaxHeartrate { get; set; }

        /// <summary>
        /// Rides with power meter data only.
        /// </summary>
        [JsonProperty("max_watts")]
        public int MaxWatts { get; set; }

        /// <summary>
        /// Pr count.
        /// </summary>
        [JsonProperty("pr_count")]
        public int PrCount { get; set; }

        /// <summary>
        /// The number of Instagram and Strava photos for this activity.
        /// </summary>
        [JsonProperty("total_photo_count")]
        public int TotalPhotoCount { get; set; }

        /// <summary>
        /// Whether the logged-in athlete has kudoed this activity.
        /// </summary>
        [JsonProperty("has_kudoed")]
        public bool HasKudoed { get; set; }

        /// <summary>
        /// Suffer score.
        /// </summary>
        [JsonProperty("suffer_score")]
        public int? SufferScore { get; set; }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SummaryActivityResponseModel() : base()
        {
            
        }

        #endregion

        #region Public Methods
        
        /// <inheritdoc/>
        public override string ToString() => Name;

        #endregion
    }
}