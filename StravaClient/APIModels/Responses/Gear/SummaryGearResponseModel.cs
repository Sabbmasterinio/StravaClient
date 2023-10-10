using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a summary gear.
    /// </summary>
    public class SummaryGearResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Id"/> property
        /// </summary>
        private string? mId;

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The gear's unique identifier.
        /// </summary>
        [AllowNull]
        [JsonProperty("id")]
        public string Id
        {
            get => mId ?? string.Empty;
            set => mId = value;
        }

        /// <summary>
        /// Resource state, indicates level of detail. 
        /// </summary>
        /// <remarks>
        /// Possible values: 2 -> "summary", 3 -> "detail".
        /// </remarks>
        [JsonProperty("resource_state")]
        [JsonConverter(typeof(GearResourceStateToIntJsonConverter))]
        public GearResourceState ResourceState { get; set; }

        /// <summary>
        /// Whether this gear's is the owner's default one.
        /// </summary>
        [JsonProperty("primary")]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// The gear's name.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The distance logged with this gear.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SummaryGearResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}