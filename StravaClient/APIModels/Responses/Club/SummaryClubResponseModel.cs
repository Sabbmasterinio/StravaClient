using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a summary club.
    /// </summary>
    public class SummaryClubResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of <see cref="City"/> property
        /// </summary>
        private string? mCity;

        /// <summary>
        /// The member of <see cref="State"/> property
        /// </summary>
        private string? mState;

        /// <summary>
        /// The member of <see cref="Country"/> property
        /// </summary>
        private string? mCountry;

        #endregion

        #region Public Properties

        /// <summary>
        /// The club's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>
        /// Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".
        /// </remarks>
        [JsonProperty("resource_state")]
        [JsonConverter(typeof(ResourceStateToIntJsonConverter))]
        public ResourceState ResourceState { get; set; }

        /// <summary>
        /// The club's name.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// URL to a 60x60 pixel profile picture.
        /// </summary>
        [JsonProperty("profile_medium")]
        public Uri? ProfileMedium { get; set; }

        /// <summary>
        /// The club's profile.
        /// </summary>
        [JsonProperty("profile")]
        public Uri? Profile { get; set; }

        /// <summary>
        /// URL to a ~1185x580 pixel cover photo.
        /// </summary>
        [JsonProperty("cover_photo")]
        public Uri? CoverPhoto {  get; set; }

        /// <summary>
        /// URL to a ~1185x580 pixel cover photo.
        /// </summary>
        [JsonProperty("cover_photo_small")]
        public Uri? CoverPhotoSmall {  get; set; }

        /// <summary>
        /// The club's city.
        /// </summary>
        [AllowNull]
        [JsonProperty("city")]
        public string City
        {
            get => mCity ?? string.Empty;
            set => mCity = value;
        }

        /// <summary>
        /// The club's state or geographical region.
        /// </summary>
        [AllowNull]
        [JsonProperty("state")]
        public string State
        {
            get => mState ?? string.Empty;
            set => mState = value;
        }

        /// <summary>
        /// The club's country.
        /// </summary>
        [AllowNull]
        [JsonProperty("country")]
        public string Country
        {
            get => mCountry ?? string.Empty;
            set => mCountry = value;
        }

        /// <summary>
        /// Whether the club is private.
        /// </summary>
        [JsonProperty("private")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Whether the club is private.
        /// </summary>
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        /// <summary>
        /// Whether the club is featured or not.
        /// </summary>
        [JsonProperty("featured")]
        public bool IsFeatured { get; set; }

        /// <summary>
        /// Whether the club is verified or not.
        /// </summary>
        [JsonProperty("verified")]
        public bool IsVerified { get; set; }

        /// <summary>
        /// The club's vanity URL.
        /// </summary>
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        #endregion

        #region Constructors

        #endregion

        #region Public Methods

        #endregion
    }

}