using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StravaClient
{
    /// <summary>
    /// Represents a highlighted kudoser
    /// </summary>
    public class HighLightedKudoserResponseModel
    {
        #region Private Members
        
        /// <summary>
        /// The member of <see cref="DisplayName"/> property
        /// </summary>
        private string? mDisplayName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The destination url.
        /// </summary>
        [JsonProperty("destination_url")]
        public Uri? DestinationUrl { get; set; }
        
        /// <summary>
        /// The display name.
        /// </summary>
        [AllowNull]
        [JsonProperty("display_name")]
        public string DisplayName
        {
            get => mDisplayName ?? string.Empty;
            set => mDisplayName = value;
        }
        
        /// <summary>
        /// The avatar url.
        /// </summary>
        [JsonProperty("avatar_url")]
        public Uri? AvatarUrl { get; set; }
        
        /// <summary>
        /// Shows name or not.
        /// </summary>
        [JsonProperty("show_name")]
        public bool ShowName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public HighLightedKudoserResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => DisplayName;

        #endregion
    }
}
