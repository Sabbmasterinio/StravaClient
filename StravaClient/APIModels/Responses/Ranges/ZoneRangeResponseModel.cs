using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
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
    }
}