using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Linq;

namespace StravaClient
{
    /// <summary>
    /// Represents a summary segment.
    /// </summary>
    public class SummarySegmentEffortResponseModel
    {
        #region Private Properties

        /// <summary>
        /// The member of <see cref="Achievements"/> property
        /// </summary>
        private IEnumerable<object>? mAchievements;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of this effort.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The unique identifier of the activity related to this effort.
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// The effort's elapsed time.
        /// </summary>
        [JsonProperty("elapsed_time")]
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan ElapsedTime { get; set; }

        /// <summary>
        /// The time at which the effort was started.
        /// </summary>
        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The time at which the effort was started in the local timezone.
        /// </summary>
        [JsonProperty("start_date_local")]
        public DateTimeOffset StartDateLocal { get; set; }

        /// <summary>
        /// The effort's distance in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// Whether this effort is the current best on the leaderboard.
        /// </summary>
        [JsonProperty("is_kom")]
        public bool IsKom { get; set; }

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
        /// the achievements
        /// </summary>
        [JsonProperty("achievements")]
        public IEnumerable<object> Achievements 
        { 
            get => mAchievements ?? Enumerable.Empty<object>();
            set => mAchievements = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SummarySegmentEffortResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => "The effort's distance in meters : " + Distance;

        #endregion
    }
}