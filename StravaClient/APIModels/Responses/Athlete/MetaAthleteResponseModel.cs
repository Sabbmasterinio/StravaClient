using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a meta athlete.
    /// </summary>
    public class MetaAthleteResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The unique identifier of the athlete.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        #endregion

        #region Constructors

        #endregion
    }
}