using Newtonsoft.Json;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents a detailed athlete.
    /// </summary>
    public class DetailedAthleteResponseModel : SummaryAthleteResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Clubs"/> property
        /// </summary>
        private IEnumerable<SummaryClubResponseModel>? mClubs;

        /// <summary>
        /// The member of <see cref="Bikes"/> property
        /// </summary>
        private IEnumerable<SummaryGearResponseModel>? mBikes;

        /// <summary>
        /// The member of <see cref="Shoes"/> property
        /// </summary>
        private IEnumerable<SummaryGearResponseModel>? mShoes;

        #endregion

        #region Public Properties

        /// <summary>
        /// The athlete's follower count.
        /// </summary>
        [JsonProperty("follower_count")]
        public int FollowerCount { get; set; }

        /// <summary>
        /// The athlete's friend count.
        /// </summary>
        [JsonProperty("friend_count")]
        public int FriendCount { get; set; }

        /// <summary>
        /// The athlete's preferred unit system.
        /// </summary>
        /// <remarks>
        ///  May take one of the following values: feet, meters.
        /// </remarks>
        [JsonProperty("measurement_preference")]
        [JsonConverter(typeof(MeasurementPreferenceToStringJsonConverter))]
        public MeasurementPreference MeasurementPreference { get; set; }

        /// <summary>
        /// The athlete's FTP (Functional Threshold Power).
        /// </summary>
        [JsonProperty("ftp")]
        public int Ftp { get; set; }

        /// <summary>
        /// The athlete's weight.
        /// </summary>
        [JsonProperty("weight")]
        public float Weight { get; set; }

        /// <summary>
        /// The athlete's clubs.
        /// </summary>
        [JsonProperty("clubs")]
        public IEnumerable<SummaryClubResponseModel> Clubs
        {
            get => mClubs ?? Enumerable.Empty<SummaryClubResponseModel>();
            set => mClubs = value;
        }

        /// <summary>
        /// The athlete's bikes.
        /// </summary>
        [JsonProperty("bikes")]
        public IEnumerable<SummaryGearResponseModel> Bikes
        {
            get => mBikes ?? Enumerable.Empty<SummaryGearResponseModel>();
            set => mBikes = value;
        }

        /// <summary>
        /// The athlete's shoes.
        /// </summary>
        [JsonProperty("shoes")]
        public IEnumerable<SummaryGearResponseModel> Shoes
        {
            get => mShoes ?? Enumerable.Empty<SummaryGearResponseModel>();
            set => mShoes = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DetailedAthleteResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString()
        {
            return "The athlete's follower count : " + FollowerCount;
        }

        #endregion
    }
}