using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace StravaClient
{
    /// <summary>
    /// Request model used for getting a new token.
    /// </summary>
    public class RefreshTokenRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The application’s ID, obtained during registration.
        /// </summary>
        [JsonProperty("client_id")]
        public int? ClientId { get; set; }

        /// <summary>
        /// The application’s secret, obtained during registration.
        /// </summary>
        [AllowNull]
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The grant type for the request. When refreshing an access token, must always be "refresh_token".
        /// </summary>
        [AllowNull]
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// The refresh token for this user, to be used to get the next access token for this user. 
        /// </summary>
        /// <remarks>
        /// Please expect that this value can change anytime you retrieve a new access token.
        /// Once a new refresh token code has been returned, the older code will no longer work.
        /// </remarks>
        [JsonProperty("refresh_token")]
        public string? RefreshToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public RefreshTokenRequestModel(int clientId, string clientSecret, string refreshToken) : base()
        {
            if (string.IsNullOrEmpty(clientSecret))
                throw new ArgumentException($"'{nameof(clientSecret)}' cannot be null or empty.", nameof(clientSecret));
            
            if (string.IsNullOrEmpty(refreshToken))
                throw new ArgumentException($"'{nameof(refreshToken)}' cannot be null or empty.", nameof(refreshToken));

            ClientId = clientId;
            ClientSecret = clientSecret;
            GrantType = "refresh_token";
            RefreshToken = refreshToken;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public RefreshTokenRequestModel() : base()
        {

        }

        #endregion
    }
}