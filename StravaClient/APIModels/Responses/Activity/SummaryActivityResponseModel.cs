using Newtonsoft.Json;
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
        /// The member of <see cref="StartLatlng"/> property
        /// </summary>
        private IEnumerable<float>? mStartLatlng;

        /// <summary>
        /// The member of <see cref="EndLatlng"/> property
        /// </summary>
        private IEnumerable<float>? mEndLatlng;

        /// <summary>
        /// The member of <see cref="Map"/> property
        /// </summary>
        private PolylineMapResponseModel? mMap;

        /// <summary>
        /// The member of <see cref="UploadIdStr"/> property
        /// </summary>
        private string? mUploadIdStr;

        #endregion

        #region Public Properties

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
        [JsonProperty("upload_id")]
        public long UploadId { get; set; }

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
        /// The activity's highest elevation, in meters.
        /// </summary>
        [JsonProperty("elev_high")]
        public float ElevationHigh { get; set; }

        /// <summary>
        /// The activity's lowest elevation, in meters.
        /// </summary>
        [JsonProperty("elev_low")]
        public float ElevationLow { get; set; }

        /// <summary>
        /// An instance of SportType.
        /// </summary>
        [JsonProperty("sport_type")]
        [JsonConverter(typeof(SportTypeToStringJsonConverter))]
        public SportType SportType { get; set; }

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
        /// An instance of LatLng.
        /// </summary>
        [JsonProperty("start_latlng")]
        public IEnumerable<float> StartLatlng
        {
            get => mStartLatlng ?? Enumerable.Empty<float>();

            set => mStartLatlng = value;
        }

        /// <summary>
        /// An instance of LatLng.
        /// </summary>
        [JsonProperty("end_latlng")]
        public IEnumerable<float> EndLatlng
        {
            get => mEndLatlng ?? Enumerable.Empty<float>();

            set => mEndLatlng = value;
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
        /// The number of Instagram and Strava photos for this activity.
        /// </summary>
        [JsonProperty("total_photo_count")]
        public int TotalPhotoCount { get; set; }

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
        public bool Trainer { get; set; }

        /// <summary>
        /// Whether this activity is a commute.
        /// </summary>
        [JsonProperty("commute")]
        public bool Commute { get; set; }

        /// <summary>
        /// Whether this activity was created manually.
        /// </summary>
        [JsonProperty("manual")]
        public bool Manual { get; set; }

        /// <summary>
        /// Whether this activity is private.
        /// </summary>
        [JsonProperty("private")]
        public bool Private { get; set; }

        /// <summary>
        /// Whether this activity is flagged.
        /// </summary>
        [JsonProperty("flagged")]
        public bool Flagged { get; set; }

        /// <summary>
        /// The activity's workout type.
        /// </summary>
        [JsonProperty("workout_type")]
        public int WorkoutType { get; set; }

        /// <summary>
        /// The unique identifier of the upload in string format.
        /// </summary>
        [AllowNull]
        [JsonProperty("upload_id_str")]
        public string UploadIdStr
        {
            get => mUploadIdStr ?? string.Empty;
            set => mUploadIdStr = value;
        }

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
        /// Whether the logged-in athlete has kudoed this activity.
        /// </summary>
        [JsonProperty("has_kudoed")]
        public bool HasKudoed { get; set; }

        /// <summary>
        /// Whether the activity is muted.
        /// </summary>
        [JsonProperty("hide_from_home")]
        public bool HideFromHome { get; set; }

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
        /// The total work done in kilojoules during this activity. Rides only.
        /// </summary>
        [JsonProperty("kilojoules")]
        public float Kilojoules { get; set; }

        /// <summary>
        /// Average power output in watts during this activity. Rides only.
        /// </summary>
        [JsonProperty("average_watts")]
        public float AverageWatts { get; set; }

        /// <summary>
        /// Whether the watts are from a power meter, false if estimated.
        /// </summary>
        [JsonProperty("device_watts")]
        public bool DeviceWatts { get; set; }

        /// <summary>
        /// Rides with power meter data only.
        /// </summary>
        [JsonProperty("max_watts")]
        public int MaxWatts { get; set; }

        /// <summary>
        /// Similar to Normalized Power. Rides with power meter data only.
        /// </summary>
        [JsonProperty("weighted_average_watts")]
        public int WeightedAverageWatts { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SummaryActivityResponseModel() : base()
        {

        }

        #endregion

        /// <inheritdoc/>
        #region Public Methods

        public override string ToString() => Name;

        #endregion
    }
}