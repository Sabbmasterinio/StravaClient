using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

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

        /// <summary>
        /// The member of <see cref="Urls"/> property
        /// </summary>
        private string? mUrls;

        #endregion

        #region Public Properties

        /// <summary>
        /// An instance of long.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

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
        /// An instance of string.
        /// </summary>
        [AllowNull]
        [JsonProperty("urls")]
        public string Urls
        {
            get => mUrls ?? string.Empty;
            set => mUrls = value;
        }

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

        #endregion
    }

}