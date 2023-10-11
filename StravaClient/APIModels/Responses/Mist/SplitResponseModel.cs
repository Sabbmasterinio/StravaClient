using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a split.
    /// </summary>
    public class SplitResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The average speed of this split, in meters per second.
        /// </summary>
        [JsonProperty("average_speed")]
        public float AverageSpeed { get; set; }

        /// <summary>
        /// The distance of this split, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The elapsed time of this split, in seconds.
        /// </summary>
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        /// <summary>
        /// The elevation difference of this split, in meters.
        /// </summary>
        [JsonProperty("elevation_difference")]
        public int ElevationDifference { get; set; }

        /// <summary>
        /// The pacing zone of this split.
        /// </summary>
        [JsonProperty("pace_zone")]
        public int PaceZone { get; set; }

        /// <summary>
        /// The moving time of this split, in seconds.
        /// </summary>
        [JsonProperty("moving_time")]
        public int MovingTime { get; set; }

        /// <summary>
        /// N/A
        /// </summary>
        [JsonProperty("split")]
        public int Split { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SplitResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => "The distance of this split, in meters : " + Distance;

        #endregion
    }
}