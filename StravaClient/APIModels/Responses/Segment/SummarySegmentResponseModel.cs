using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a summary segment.
    /// </summary>
    public class SummarySegmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of <see cref="StartLatlng"/> property
        /// </summary>
        private IEnumerable<float>? mStartLatlng;

        /// <summary>
        /// The member of <see cref="EndLatlng"/> property
        /// </summary>
        private IEnumerable<float>? mEndLatlng;

        /// <summary>
        /// The member of <see cref="City"/> property
        /// </summary>
        private string? mCity;

        /// <summary>
        /// The member of <see cref="State"/> property
        /// </summary>
        private string? mState;

        /// <summary>
        /// The member of <see cref="Country"/> property
        /// </summary>
        private string? mCountry;

        /// <summary>
        /// The member of <see cref="AthletePrEffort"/> property
        /// </summary>
        private SummaryPRSegmentEffortResponseModel? mAthletePrEffort;

        /// <summary>
        /// The member of <see cref="AthleteSegmentStats"/> property
        /// </summary>
        private SummarySegmentEffortResponseModel? mAthleteSegmentStats;

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
        /// May take one of the following values: Ride, Run.
        /// </summary>
        [JsonProperty("activity_type")]
        [JsonConverter(typeof(SegmentActivityTypeToStringJsonConverter))]
        public SegmentActivityType ActivityType { get; set; }

        /// <summary>
        /// The segment's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The segment's average grade, in percents.
        /// </summary>
        [JsonProperty("average_grade")]
        public float AverageGrade { get; set; }

        /// <summary>
        /// The segments's maximum grade, in percents.
        /// </summary>
        [JsonProperty("maximum_grade")]
        public float MaximumGrade { get; set; }

        /// <summary>
        /// The segments's highest elevation, in meters.
        /// </summary>
        [JsonProperty("elevation_high")]
        public float ElevationHigh { get; set; }

        /// <summary>
        /// The segments's lowest elevation, in meters.
        /// </summary>
        [JsonProperty("elevation_low")]
        public float ElevationLow { get; set; }

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
        /// The category of the climb [0, 5]. Higher is harder.
        /// </summary>
        /// <remarks>
        /// ie. 5 is Hors catégorie, 0 is uncategorized in climb_category.
        /// </remarks>
        [JsonProperty("climb_category")]
        [JsonConverter(typeof(ClimbCategoryToIntJsonConverter))]
        public ClimbCategory ClimbCategory { get; set; }

        /// <summary>
        /// The segments's city.
        /// </summary>
        [AllowNull]
        [JsonProperty("city")]
        public string City
        {
            get => mCity ?? string.Empty;
            set => mCity = value;
        }

        /// <summary>
        /// The segments's state or geographical region.
        /// </summary>
        [AllowNull]
        [JsonProperty("state")]
        public string State
        {
            get => mState ?? string.Empty;
            set => mState = value;
        }

        /// <summary>
        /// The segment's country.
        /// </summary>
        [AllowNull]
        [JsonProperty("country")]
        public string Country
        {
            get => mCountry ?? string.Empty;
            set => mCountry = value;
        }

        /// <summary>
        /// Whether this segment is private.
        /// </summary>
        [JsonProperty("private")]
        public bool Private { get; set; }

        /// <summary>
        /// An instance of SummaryPRSegmentEffort.
        /// </summary>
        [JsonProperty("athlete_pr_effort")]
        public SummaryPRSegmentEffortResponseModel AthletePrEffort
        {
            get => mAthletePrEffort ??= new();
            set => mAthletePrEffort = value;
        }

        /// <summary>
        /// An instance of SummarySegmentEffort.
        /// </summary>
        [JsonProperty("athlete_segment_stats")]
        public SummarySegmentEffortResponseModel AthleteSegmentStats
        {
            get => mAthleteSegmentStats ??= new();
            set => mAthleteSegmentStats = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SummarySegmentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }
}