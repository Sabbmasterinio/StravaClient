using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace StravaClient
{
    /// <summary>
    /// Represents an explorer segment.
    /// </summary>
    public class ExplorerSegmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of <see cref="Name"/> property
        /// </summary>
        private string? mName;

        /// <summary>
        /// The member of <see cref="Points"/> property
        /// </summary>
        private string? mPoints;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of this segment.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The name of this segment.
        /// </summary>
        [AllowNull]
        [JsonProperty("name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The category of the climb [0, 5]. Higher is harder.
        /// </summary>
        /// <remarks>
        /// ie. 5 is Hors catégorie, 0 is uncategorized in climb_category.
        /// If climb_category = 5, climb_category_desc = HC. If climb_category = 2,
        /// climb_category_desc = 3.
        /// </remarks>
        [JsonProperty("climb_category")]
        [JsonConverter(typeof(ClimbCategoryToIntJsonConverter))]
        public ClimbCategory ClimbCategory { get; set; }

        /// <summary>
        /// The description for the category of the climb.
        /// </summary>
        /// <remarks>
        /// May take one of the following values: NC, 4, 3, 2, 1, HC.
        /// </remarks>
        [AllowNull]
        [JsonProperty("climb_category_desc")]
        [JsonConverter(typeof(ClimbCategoryToStringJsonConverter))]
        public ClimbCategory ClimbCategoryDesc { get; set; }

        /// <summary>
        /// The segment's average grade, in percents.
        /// </summary>
        [JsonProperty("avg_grade")]
        public float AvgGrade { get; set; }

        /// <summary>
        /// An instance of LatLng.
        /// </summary>
        [JsonProperty("start_latlng")]
        public Coordinates StartLatitudeLongitude { get; set; }

        /// <summary>
        /// An instance of LatLng.
        /// </summary>
        [JsonProperty("end_latlng")]
        public Coordinates EndLatitudeLongitude { get; set; }

        /// <summary>
        /// The segments's elevation difference, in meters.
        /// </summary>
        [JsonProperty("elev_difference")]
        public float ElevationDifference { get; set; }

        /// <summary>
        /// The segments's distance, in meters.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }

        /// <summary>
        /// The polyline of the segment.
        /// </summary>
        [AllowNull]
        [JsonProperty("points")]
        public string Points
        {
            get => mPoints ?? string.Empty;
            set => mPoints = value;
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
        /// Whether this route is starred by the logged-in athlete.
        /// </summary>
        [JsonProperty("starred")]
        public bool IsStarred { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExplorerSegmentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Name;

        #endregion
    }
}