using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a detailed club.
    /// </summary>
    public class DetailedClubResponseModel : SummaryClubResponseModel
    {
        #region Public Properties

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
        /// Whether the currently logged-in athlete is an administrator of this club.
        /// </summary>
        [JsonProperty("admin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Whether the currently logged-in athlete is the owner of this club.
        /// </summary>
        [JsonProperty("owner")]
        public bool IsOwner { get; set; }

        /// <summary>
        /// The number of athletes in the club that the logged-in athlete follows.
        /// </summary>
        [JsonProperty("following_count")]
        public int FollowingCount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailedClubResponseModel() : base()
        {

        }

        #endregion
    }
}