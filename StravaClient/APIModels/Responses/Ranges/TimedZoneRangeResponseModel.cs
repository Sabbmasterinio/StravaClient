using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// A union type representing the time spent in a given zone.
    /// </summary>
    public class TimedZoneRangeResponseModel
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

        /// <summary>
        /// The number of seconds spent in this zone.
        /// </summary>
        [JsonProperty("time")]
        public int Time { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimedZoneRangeResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}