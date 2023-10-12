using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a meta activity.
    /// </summary>
    public class MetaActivityResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The unique identifier of the activity.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>
        /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
        /// </remarks>
        [JsonProperty("resource_state")]
        [JsonConverter(typeof(ResourceStateToIntJsonConverter))]
        public ResourceState ResourceState { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MetaActivityResponseModel() : base()
        {

        }

        #endregion
    }
}