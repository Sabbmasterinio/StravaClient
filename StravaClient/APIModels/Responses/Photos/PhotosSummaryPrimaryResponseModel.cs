using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Xml.Linq;

namespace StravaClient
{
    /// <summary>
    /// Represents a photo summary primary.
    /// </summary>
    public class PhotosSummaryPrimaryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="UniqueId"/> property
        /// </summary>
        private string? mUniqueId;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of long.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// An instance of integer.
        /// </summary>
        [JsonProperty("source")]
        public int Source { get; set; }

        /// <summary>
        /// An instance of string.
        /// </summary>
        [AllowNull]
        [JsonProperty("unique_id")]
        public string UniqueId
        {
            get => mUniqueId ?? string.Empty;
            set => mUniqueId = value;
        }

        /// <summary>
        /// Urls.
        /// </summary>
        [JsonProperty("urls")]
        public object? Urls { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PhotosSummaryPrimaryResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => UniqueId;

        #endregion
    }
}