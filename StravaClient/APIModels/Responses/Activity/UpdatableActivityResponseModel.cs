using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents an updatable activity.
    /// </summary>
    public class UpdatableActivityResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Description"/> property
        /// </summary>
        private string? mDescription;
        
        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;
        
        /// <summary>
        /// The member of <see cref="GearId"/> property
        /// </summary>
        private string? mGearId;

        #endregion

        #region Public Properties

        /// <summary>
        /// Whether this activity is a commute.
        /// </summary>
        [JsonProperty("commute")]
        public bool Commute { get; set; }

        /// <summary>
        /// Whether this activity was recorded on a training machine.
        /// </summary>
        [JsonProperty("trainer")]
        public bool Trainer { get; set; }

        /// <summary>
        /// Whether this activity is muted.
        /// </summary>
        [JsonProperty("hide_from_home")]
        public bool HideFromHome { get; set; }

        /// <summary>
        /// The description of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// An instance of SportType.
        /// </summary>
        [JsonProperty("sport_type")]
        public SportType SportType { get; set; }

        /// <summary>
        /// Identifier for the gear associated with the activity.
        /// ‘none’ clears gear from activity.
        /// </summary>
        [AllowNull]
        [JsonProperty("gear_id")]
        public string GearId 
        { 
            get => mGearId ?? string.Empty; 
            set => mGearId = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UpdatableActivityResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        #endregion
    }

}