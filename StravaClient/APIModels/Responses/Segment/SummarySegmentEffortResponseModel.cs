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
        public int ElapsedTime { get; set; }

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

        public override string ToString() => "The effort's distance in meters : " + Distance;

        #endregion
    }
}