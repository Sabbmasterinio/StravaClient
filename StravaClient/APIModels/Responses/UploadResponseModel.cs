using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents an upload.
    /// </summary>
    public class UploadResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="IdStr"/> property
        /// </summary>
        private string? mIdStr;

        /// <summary>
        /// The member of <see cref="ExternalId"/> property
        /// </summary>
        private string? mExternalId;

        /// <summary>
        /// The member of <see cref="Error"/> property
        /// </summary>
        private string? mError;

        /// <summary>
        /// The member of <see cref="Status"/> property
        /// </summary>
        private string? mStatus;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of the upload.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The unique identifier of the upload in string format.
        /// </summary>
        [AllowNull]
        [JsonProperty("id_str")]
        public string IdStr
        {
            get => mIdStr ?? string.Empty;
            set => mIdStr = value;
        }

        /// <summary>
        /// The external identifier of the upload.
        /// </summary>
        [AllowNull]
        [JsonProperty("external_id")]
        public string ExternalId
        {
            get => mExternalId ?? string.Empty;
            set => mExternalId = value;
        }

        /// <summary>
        /// The error associated with this upload.
        /// </summary>
        [AllowNull]
        [JsonProperty("error")]
        public string Error
        {
            get => mError ?? string.Empty;
            set => mError = value;
        }

        /// <summary>
        /// The status of this upload.
        /// </summary>
        [AllowNull]
        [JsonProperty("status")]
        public string Status
        {
            get => mStatus ?? string.Empty;
            set => mStatus = value;
        }

        /// <summary>
        /// The identifier of the activity this upload resulted into.
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UploadResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => IdStr;

        #endregion
    }
}