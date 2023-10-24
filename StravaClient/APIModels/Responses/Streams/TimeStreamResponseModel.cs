using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a time stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of time values for this stream.
    /// </remarks>
    public class TimeStreamResponseModel : BaseEnumerableDataStreamResponseModel<TimeSpan>
    {
        #region Public Properties

        /// <inheritdoc/>
        [JsonProperty("data")]
        [JsonConverter(typeof(TimeSpanEnumerableToIntArrayEnumerableJsonConverter))]
        public override IEnumerable<TimeSpan> Data { get => base.Data; set => base.Data = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TimeStreamResponseModel() : base()
        {
        }

        #endregion
    }
}