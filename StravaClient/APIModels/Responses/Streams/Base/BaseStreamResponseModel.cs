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
        [JsonProperty("original_size")]
        public int OriginalSize { get; set; }
        
        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("resolution")]
        public StreamResolution Resolution { get; set; }
        
        /// <summary>
        /// The number of data points in this stream.
        /// </summary>
        [JsonProperty("series_type")]
        public StreamSeriesType SeriesType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseStreamResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion

    }

}