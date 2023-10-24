using Newtonsoft.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a lat lng stream.
    /// </summary>
    /// <remarks>
    /// Data: The sequence of latitude/longitude values for this stream.
    /// </remarks>
    public class CoordinatesStreamResponseModel : BaseEnumerableDataStreamResponseModel<Coordinates>
    {
        #region Public Properties

        /// <inheritdoc/>
        [JsonProperty("data")]
        [JsonConverter(typeof(CoordinatesEnumerableToDoubleArrayEnumerableJsonConverter))]
        public override IEnumerable<Coordinates> Data { get => base.Data; set => base.Data = value; }
         
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CoordinatesStreamResponseModel() : base()
        {

        }
       
        #endregion
    }

}