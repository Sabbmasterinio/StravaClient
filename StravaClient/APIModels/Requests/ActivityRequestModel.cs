using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Request model used for creating and updating an activity.
    /// </summary>
    public class ActivityRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Whether this activity is a commute.
        /// </summary>
        [JsonProperty("commute")]
        public bool? IsCommute { get; set; }

        /// <summary>
        /// Whether this activity was recorded on a training machine.
        /// </summary>
        [JsonProperty("trainer")]
        public bool? IsTrainer { get; set; }

        /// <summary>
        /// Whether this activity is muted.
        /// </summary>
        [JsonProperty("hide_from_home")]
        public bool? IsHideFromHome { get; set; }

        /// <summary>
        /// The description of the activity.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An instance of SportType.
        /// </summary>
        [JsonProperty("sport_type")]
        [JsonConverter(typeof(SportTypeToStringJsonConverter))]
        public SportType? SportType { get; set; }

        /// <summary>
        /// Identifier for the gear associated with the activity.
        /// ‘none’ clears gear from activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("gear_id")]
        public string? GearId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActivityRequestModel() : base()
        {

        }

        #endregion
    }
}