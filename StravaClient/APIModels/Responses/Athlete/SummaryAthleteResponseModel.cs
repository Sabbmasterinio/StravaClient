using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Xml.Linq;

namespace StravaClient
{
    /// <summary>
    /// Represents a summary athlete response model.
    /// </summary>
    public class SummaryAthleteResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Id"/> property
        /// </summary>
        private string? mId;

        /// <summary>
        /// The member of <see cref="Firstname"/> property
        /// </summary>
        private string? mFirstname;

        /// <summary>
        /// The member of <see cref="Lastname"/> property
        /// </summary>
        private string? mLastname;

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
        
        /// <summary>
        /// The member of <see cref="Username"/> property
        /// </summary>
        private string? mUsername;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of the athlete.
        /// </summary>
        [AllowNull]
        [JsonProperty("id")]
        public string Id 
        { 
            get => mId ?? string.Empty; 
            set => mId = value;
        }

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
        /// The athlete's first name.
        /// </summary>
        [AllowNull]
        [JsonProperty("firstname")]
        public string Firstname
        {
            get => mFirstname ?? string.Empty;
            set => mFirstname = value;
        }

        /// <summary>
        /// The athlete's last name.
        /// </summary>
        [AllowNull]
        [JsonProperty("lastname")]
        public string Lastname
        {
            get => mLastname ?? string.Empty;
            set => mLastname = value;
        }

        /// <summary>
        /// URL to a 62x62 pixel profile picture.
        /// </summary>
        [JsonProperty("profile_medium")]
        public Uri? ProfileMedium { get; set; }

        /// <summary>
        /// URL to a 124x124 pixel profile picture.
        /// </summary>
        [JsonProperty("profile")]
        public Uri? Profile { get; set; }

        /// <summary>
        /// The athlete's city.
        /// </summary>
        [AllowNull]
        [JsonProperty("city")]
        public string City
        {
            get => mCity ?? string.Empty;
            set => mCity = value;
        }

        /// <summary>
        /// The athlete's state or geographical region.
        /// </summary>
        [AllowNull]
        [JsonProperty("state")]
        public string State
        {
            get => mState ?? string.Empty;
            set => mState = value;
        }

        /// <summary>
        /// The athlete's country.
        /// </summary>
        [AllowNull]
        [JsonProperty("country")]
        public string Country
        {
            get => mCountry ?? string.Empty;
            set => mCountry = value;
        }

        /// <summary>
        /// The athlete's sex.
        /// </summary>
        /// <remarks>
        /// May take one of the following values: M, F.
        /// </remarks>
        [JsonProperty("sex")]
        [JsonConverter(typeof(AthleteSexToStringJsonConverter))]
        public AthleteSex Sex { get; set; }

        /// <summary>
        /// Whether the athlete has any Summit subscription.
        /// </summary>
        [JsonProperty("summit")]
        public bool Summit { get; set; }

        /// <summary>
        /// The time at which the athlete was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The time at which the athlete was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// The athlete's username.
        /// </summary>
        [AllowNull]
        [JsonProperty("username")]
        public string Username
        {
            get => mUsername ?? string.Empty;
            set => mUsername = value;
        }

        /// <summary>
        /// Whether the athlete is premium.
        /// </summary>
        [JsonProperty("premium")]
        public bool IsPremium { get; set; }

        /// <summary>
        /// The athlete's badge type id.
        /// </summary>
        [JsonProperty("badge_type_id")]
        public int BadgeTypeId { get; set; }

        /// <summary>
        /// The athlete's mutual friend count.
        /// </summary>
        [JsonProperty("mutual_friend_count")]
        public int MutualFriendCount { get; set; }

        /// <summary>
        /// The athlete's date preference.
        /// </summary>
        [JsonProperty("date_preference")]
        public DateOnly DatePreference { get; set; }
        
        /// <summary>
        /// The athlete's follower.
        /// </summary>
        [JsonProperty("follower")]
        public object? Follower { get; set; }
        
        /// <summary>
        /// The athlete's friend.
        /// </summary>
        [JsonProperty("friend")]
        public object? Friend { get; set; }

        /// <summary>
        /// The athlete's type.
        /// </summary>
        [JsonProperty("athlete_type")]
        public int AthleteType { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SummaryAthleteResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Firstname;

        #endregion
    }
}