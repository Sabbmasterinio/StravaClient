using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{

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
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan MovingTime { get; set; }

        /// <summary>
        /// The total elapsed time of the considered activities.
        /// </summary>
        [JsonProperty("elapsed_time")]
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan ElapsedTime { get; set; }

        /// <summary>
        /// The total elevation gain of the considered activities.
        /// </summary>
        [JsonProperty("elevation_gain")]
        public float ElevationGain { get; set; }

        /// <summary>
        /// The total number of achievements of the considered activities.
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

        /// <inheritdoc/>
        public override string ToString() => "The total number of achievements of the considered activities is : " + AchievementCount;

        #endregion
    }
}