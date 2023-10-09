using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents an error.
    /// </summary>
    public class ErrorResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Code"/> property
        /// </summary>
        private string? mCode;

        /// <summary>
        /// The member of <see cref="Field"/> property
        /// </summary>
        private string? mField;

        /// <summary>
        /// The member of <see cref="Resource"/> property
        /// </summary>
        private string? mResource;

        #endregion

        #region Public Properties

        /// <summary>
        /// The code associated with this error.
        /// </summary>
        [AllowNull]
        [JsonProperty("code")]
        public string Code
        {
            get => mCode ?? string.Empty;
            set => mCode = value;
        }

        /// <summary>
        /// The specific field or aspect of the resource associated with this error.
        /// </summary>
        [AllowNull]
        [JsonProperty("field")]
        public string Field
        {
            get => mField ?? string.Empty;
            set => mField = value;
        }

        /// <summary>
        /// The type of resource associated with this error.
        /// </summary>
        [AllowNull]
        [JsonProperty("resource")]
        public string Resource
        {
            get => mResource ?? string.Empty;
            set => mResource = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ErrorResponseModel() : base()
        {

        }
        #endregion

        #region Public Methods

        #endregion
    }

}