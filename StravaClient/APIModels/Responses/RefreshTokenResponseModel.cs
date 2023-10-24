using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace StravaClient
{
    /// <summary>
    /// Represents a new token response model.
    /// </summary>
    public class RefreshTokenResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The short-lived access token.
        /// </summary>
        [AllowNull]
        [JsonProperty("access_token")]
        public string AccessToken { get; }

        /// <summary>
        /// The number of seconds since the epoch when the provided access token will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeOffsetToIntJsonConverter))]
        public DateTimeOffset ExpiresAt{ get; }

        /// <summary>
        /// Seconds until the short-lived access token will expire.
        /// </summary>
        [JsonProperty("expires_in")]
        [JsonConverter(typeof(TimeSpanToIntJsonConverter))]
        public TimeSpan ExpiresIn { get; }

        /// <summary>
        /// The refresh token for this user, to be used to get the next access token for this user. 
        /// </summary>
        /// <remarks>
        /// Please expect that this value can change anytime you retrieve a new access token.
        /// Once a new refresh token code has been returned, the older code will no longer work.
        /// </remarks>
        [AllowNull]
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public RefreshTokenResponseModel() : base()
        {
        }

        #endregion
    }
}