using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a fault.
    /// </summary>
    /// <remarks>
    /// Encapsulates the errors that may be returned from the API.
    /// </remarks>
    public class FaultResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Errors"/> property
        /// </summary>
        private ErrorResponseModel? mErrors;

        /// <summary>
        /// The member of <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// The set of specific errors associated with this fault, if any.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorResponseModel Errors
        {
            get => mErrors ??= new();
            set => mErrors = value;
        }

        /// <summary>
        /// The message of the fault.
        /// </summary>
        [AllowNull]
        [JsonProperty("message")]
        public string Message
        {
            get => mMessage ?? string.Empty;
            set => mMessage = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FaultResponseModel() : base()
        {

        }
        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Message;

        #endregion
    }
}