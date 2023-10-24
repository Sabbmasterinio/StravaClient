using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Xml.Linq;

namespace StravaClient
{
    /// <summary>
    /// Represents a club athlete.
    /// </summary>
    public class ClubAthleteResponseModel
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
        /// The member of <see cref="Member"/> property
        /// </summary>
        private string? mMember;

        #endregion

        #region Public Properties

        /// <summary>
        /// Resource state, indicates level of detail.
        /// </summary>
        /// <remarks>Possible values: 1 -> "meta", 2 -> "summary", 3 -> "detail".</remarks>
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
        /// The athlete's last initial.
        /// </summary>
        [AllowNull]
        [JsonProperty("lastname")]
        public string Lastname
        {
            get => mLastname ?? string.Empty;
            set => mLastname = value;
        }

        /// <summary>
        /// The membership status of the logged-in athlete.
        /// </summary>
        /// <remarks>
        ///  May take one of the following values: member, pending.
        /// </remarks>
        [JsonProperty("membership")]
        [JsonConverter(typeof(MembershipToStringJsonConverter))]
        public Membership Membership { get; set; }

        /// <summary>
        /// Whether the athlete is a club admin.
        /// </summary>
        [JsonProperty("admin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Whether the athlete is club owner.
        /// </summary>
        [JsonProperty("owner")]
        public bool IsOwner { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClubAthleteResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Firstname;

        #endregion
    }
}