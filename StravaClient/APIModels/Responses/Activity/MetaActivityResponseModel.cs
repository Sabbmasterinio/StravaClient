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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MetaActivityResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}