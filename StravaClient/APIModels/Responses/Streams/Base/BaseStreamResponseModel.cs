using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a base stream.
    /// </summary>
    public class BaseStreamResponseModel 
    {
        #region Public Properties

        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("series_type")]
        [JsonConverter(typeof(StreamSeriesTypeToStringJsonConverter))]
        public StreamSeriesType SeriesType { get; set; }

        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("original_size")]
        public int OriginalSize { get; set; }
        
        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("resolution")]
        [JsonConverter(typeof(StreamResolutionToStringJsonConverter))]
        public StreamResolution Resolution { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseStreamResponseModel() : base()
        {

        }

        #endregion
    }
}