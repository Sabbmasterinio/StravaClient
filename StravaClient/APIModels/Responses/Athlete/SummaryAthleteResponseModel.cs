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
        /// The member of <see cref="Firstname"/> property
        /// </summary>
        private string? mFirstname;

        /// <summary>
        /// The member of <see cref="Lastname"/> property
        /// </summary>
        private string? mLastname;

        /// <summary>
        /// The member of <see cref="ProfileMedium"/> property
        /// </summary>
        private string? mProfileMedium;

        /// <summary>
        /// The member of <see cref="Profile"/> property
        /// </summary>
        private string? mProfile;

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
        /// The unique identifier of the athlete.
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
        [AllowNull]
        [JsonProperty("profile_medium")]
        public string ProfileMedium
        {
            get => mProfileMedium ?? string.Empty;
            set => mProfileMedium = value;
        }

        /// <summary>
        /// URL to a 124x124 pixel profile picture.
        /// </summary>
        [AllowNull]
        [JsonProperty("profile")]
        public string Profile
        {
            get => mProfile ?? string.Empty;
            set => mProfile = value;
        }

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
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time at which the athlete was last updated.
        /// </summary>
        [JsonProperty("upadted_at")]
        public DateTime UpdatedAt { get; set; }

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