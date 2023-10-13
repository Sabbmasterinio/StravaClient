using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a detailed segment effort.
    /// </summary>
    public class DetailedSegmentEffortResponseModel : SummarySegmentEffortResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of <see cref="Activity"/> property
        /// </summary>
        private MetaActivityResponseModel? mActivity;

        /// <summary>
        /// The member of <see cref="Athlete"/> property
        /// </summary>
        private MetaAthleteResponseModel? mAthlete;

        /// <summary>
        /// The member of <see cref="Segment"/> property
        /// </summary>
        private SummarySegmentResponseModel? mSegment;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name of the segment on which this effort was performed.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ??= string.Empty;
            set => mName = value;
        }

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
        /// The effort's moving time.
        /// </summary>
        [JsonProperty("moving_time")]
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan MovingTime { get; set; }

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
        /// The effort's average cadence.
        /// </summary>
        [JsonProperty("average_cadence")]
        public float AverageCadence { get; set; }

        /// <summary>
        /// The average wattage of this effort.
        /// </summary>
        [JsonProperty("average_watts")]
        public float AverageWatts { get; set; }

        /// <summary>
        /// For riding efforts, whether the wattage was 
        /// reported by a dedicated recording device.
        /// </summary>
        [JsonProperty("device_watts")]
        public bool IsDeviceWatts { get; set; }

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
        /// An instance of SummarySegment.
        /// </summary>
        [JsonProperty("segment")]
        public SummarySegmentResponseModel Segment
        {
            get => mSegment ??= new();
            set => mSegment = value;
        }

        /// <summary>
        /// The rank of the effort on the global leaderboard if it 
        /// belongs in the top 10 at the time of upload.
        /// </summary>
        [JsonProperty("kom_rank")]
        public int? KomRank { get; set; }

        /// <summary>
        /// The rank of the effort on the athlete's leaderboard if
        /// it belongs in the top 3 at the time of upload.
        /// </summary>
        [JsonProperty("pr_rank")]
        public int? PrRank { get; set; }

        /// <summary>
        /// Whether this effort should be hidden when viewed within an activity.
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailedSegmentEffortResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Name;

        #endregion
    }
}